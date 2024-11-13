using DATALAYER;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class DatPhongForm : DevExpress.XtraEditors.XtraForm
    {
        public DatPhongForm()
        {
            HamChucNang.PhongDatPhong += DataPhongLoading;

            HamChucNang.BookPhong += TotalDataLoading;

            HamChucNang.BangKhach += KhachSLUELoading;

            InitializeComponent();
        }

        readonly KhachHangBackend KhachHangHandle = new();

        readonly TangHotelBackend TangHotelHandle = new();

        readonly PhongNghiBackend PhongNghiHandle = new();

        readonly PhongDatBackend PhongDatHandle = new();

        readonly HoaDonPhongBackend HoaDonHandle = new();

        readonly LoaiHinhDPBackend LoaiHinhDPHandle = new();

        readonly TrangThaiDPBackend TrangThaiHandle = new();

        List<DatPhongOCustom> Save;

        String TimeLine;

        String KhachHang;

        String PhongNghi;

        String PHONGNGHI;

        String LoaiHinh;

        String TrangThai;

        String TRANGTHAI;

        String Info;

        public void DataPhongLoading()
        {
            PhongSLUELoading();

            BangPhongLoading();

            LoadThongSoPhong();
        }

        public void TotalDataLoading()
        {
            BangSuKienLoading();

            DataPhongLoading();
        }

        public void PhongSLUELoading()
        {
            PhongNghi_SLUE.Properties.DataSource = PhongNghiHandle.LoadDataTable().ToList();
        }

        public void KhachSLUELoading()
        {
            KhachHang_SLUE.Properties.DataSource = KhachHangHandle.LoadDataTable().ToList();
        }

        public void BangPhongLoading()
        {
            foreach (GalleryItemGroup Group in PGC.Gallery.Groups) { Group.Items.Clear(); }

            PGC.Gallery.Groups.Clear();

            foreach (TangHotelCustom Tang in TangHotelHandle.LoadDataTable())
            {
                GalleryItemGroup GIG = new GalleryItemGroup { Caption = Tang.TENTANG, Tag = Tang.TANGTHU };

                List<PhongNghiCustom> PhongOList = PhongNghiHandle.LoadDataTable(Tang.TANGTHU, TRANGTHAI);

                if (!PhongOList.Any())
                {
                    continue;
                }

                foreach (PhongNghiCustom Phong in PhongOList)
                {
                    GalleryItem NewPhong = new GalleryItem();

                    NewPhong.Caption = Phong.TENPHONG;

                    NewPhong.Value = Phong.MAPHONG;

                    NewPhong.Description = Phong.TENLOAIPHONG;

                    switch (Phong.MATRANGTHAI)
                    {
                        case "AVAILABLE":

                            NewPhong.ImageOptions.Image = Properties.Resources.Available;

                            break;

                        case "RESERVED":

                            NewPhong.ImageOptions.Image = Properties.Resources.Reserved;

                            break;

                        case "OCCUPIED":

                            NewPhong.ImageOptions.Image = Properties.Resources.Occupied;

                            break;

                        case "SUSPENDED":

                            NewPhong.ImageOptions.Image = Properties.Resources.Suspended;

                            break;
                    }

                    GIG.Items.Add(NewPhong);
                }

                PGC.Gallery.Groups.Add(GIG);
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoaiHinh_SLUE.Properties.DataSource = LoaiHinhDPHandle.LoadDataTable();

            TrangThai_SLUE.Properties.DataSource = TrangThaiHandle.LoadDataTable();

            TimeLine = TimeLine_CBB.EditValue.ToString();

            InitialAppearance();

            TotalDataLoading();

            KhachSLUELoading();
        }

        private void TimeLine_EditValueChanged(object sender, EventArgs e)
        {
            TimeLine = TimeLine_CBB.EditValue.ToString();

            BangSuKienLoading();
        }

        private void KhachHang_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = KhachHang_SLUE.EditValue;

            KhachHang = (Value != null) ? Value.ToString() : String.Empty;

            BangSuKienLoading();
        }

        private void PhongNghi_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = PhongNghi_SLUE.EditValue;

            PhongNghi = (Value != null) ? Value.ToString() : String.Empty;

            BangSuKienLoading();
        }

        private void LoaiHinh_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = LoaiHinh_SLUE.EditValue;

            LoaiHinh = (Value != null) ? Value.ToString() : String.Empty;

            BangSuKienLoading();
        }

        private void TrangThaiPD_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_SLUE.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            BangSuKienLoading();
        }

        private void DatPhongSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String GetSearchText = DatPhongSearch.Text.Trim();

                Object Value = PhongDatHandle.SearchKhach(GetSearchText);

                if (HamChucNang.IsFieldNull(Value))
                {
                    BangSuKien.DataSource = Save;
                }
                else
                {
                    BangSuKien.DataSource = Value;
                }
            }
        }

        private void NutDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinDatPhong DatPhong = new ThongTinDatPhong();

            DatPhong.ShowDialog();
        }

        private void NutHuyPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HamChucNang.ShowAlert("Bạn có muốn hủy lịch đặt phòng này chứ") == DialogResult.OK)
            {
                if (BangSuKien.SelectedRows.Count > 0)
                {
                    DataGridViewRow GetRow = BangSuKien.SelectedRows[0];

                    String TrangThai = GetRow.Cells["MATRANGTHAI"].Value.ToString();

                    String MaDatPhong = GetRow.Cells["MAPHONGDAT"].Value.ToString();

                    if (TrangThai == "RESERVED")
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        String KhachHang = GetRow.Cells["HOVATEN"].Value.ToString();

                        PhongDatHandle.Cancel(MaDatPhong);

                        Boolean Yes = PhongDatHandle.Notice(MaDatPhong, "CANCELED");

                        AlertInfo BuildInfo;

                        if (Yes)
                        {
                            String Message = $"THÔNG BÁO XÁC NHẬN HỦY ĐẶT PHÒNG ĐÃ GỬI ĐẾN KHÁCH {KhachHang}";

                            BuildInfo = new AlertInfo("THÔNG BÁO", Message, Properties.Resources.EmailSuccess);
                        }
                        else
                        {
                            String Message = $"KHÔNG THỂ GỬI THÔNG BÁO XÁC NHẬN HỦY ĐẶT ĐẾN KHÁCH {KhachHang}";

                            BuildInfo = new AlertInfo("THÔNG BÁO", Message, Properties.Resources.EmailIsError);
                        }

                        ThongBaoKhachHang.Show(Owner, BuildInfo);

                        HoaDonHandle.Remove(MaDatPhong);

                        HamChucNang.CapNhatCheckInOut();

                        HamChucNang.CapNhatBangPhong();

                        HamChucNang.CapNhatBangHoaDonPhong();

                        TotalDataLoading();

                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        HamChucNang.ShowError("Không thể hủy vì thời hạn đang hiệu lực hoặc đã hết");
                    }
                }
                else
                {
                    HamChucNang.ShowError("Không thể hủy đặt phòng vì không có hàng nào được chọn");
                }
            }
        }

        Boolean FloatingNoteShow = false;

        private void GalleryItemHover(object sender, GalleryItemEventArgs e)
        {
            GalleryItem FocusRoom = e.Item;

            String MaPhong = FocusRoom.Value.ToString();

            if (String.IsNullOrEmpty(MaPhong) == false)
            {
                DatPhongOCustom InEffect = PhongDatHandle.InEffect(MaPhong);

                if (!HamChucNang.IsFieldNull(InEffect))
                {
                    String Line1 = $"Tên khách: {InEffect.HOVATEN}";

                    String Line2 = $"Mã khách: {InEffect.IDKHACH}";

                    String Line3 = $"Ngày lấy: {InEffect.NGAYLAY}";

                    String Line4 = $"Ngày trả: {InEffect.NGAYTRA}";

                    String Line5 = $"Thời hạn: {InEffect.THOIHAN}";

                    Info = String.Join("\n", Line1, Line2, Line3, Line4, Line5);

                    FloatingNotes.ShowHint(Info, "THÔNG TIN!", Cursor.Position);

                    FloatingNoteShow = true;
                }
            }
        }

        private void GalleryItemLeave(object sender, GalleryItemEventArgs e)
        {
            FloatingNotes.HideHint();

            FloatingNoteShow = false;
        }

        private void PhongGalleryMouseMove(object sender, MouseEventArgs e)
        {
            if (FloatingNoteShow)
            {
                FloatingNotes.ShowHint(Info, Cursor.Position);
            }
        }

        private void PhongGalleryMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RibbonHitInfo Info = PGC.CalcHitInfo(e.Location);

                if (Info.InGalleryItem)
                {
                    PHONGNGHI = Info.GalleryItem.Value.ToString();

                    BangTuyChonPhongO.ShowPopup(Cursor.Position);

                    return;
                }

                PHONGNGHI = String.Empty;
            }
        }

        private void BangSuKien_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo H = BangSuKien.HitTest(e.X, e.Y);

                BangSuKien.ClearSelection();

                if (H.RowIndex >= 0)
                {
                    BangSuKien.Rows[H.RowIndex].Selected = true;

                    BangTuyChonSuKien.ShowPopup(Cursor.Position);
                }
            }
        }

        private void TrangThaiPO_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_RG.EditValue;

            TRANGTHAI = (Value != null) ? Value.ToString() : String.Empty;

            BangPhongLoading();
        }

        public void InitialAppearance()
        {
            if (PhanTrang.SelectedTabPage == TabSuKien)
            {
                ThanhPhanLoaiSuKien.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
            else
            {
                ThanhPhanLoaiPhongO.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
        }

        private void SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            String CurentTab = e.Page.Name;

            String PrTab = e.PrevPage.Name;

            if (PrTab == "TabSuKien" && CurentTab == "TabPhongO")
            {
                NutHuyPhong.Enabled = false;

                ThanhPhanLoaiSuKien.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

                ThanhPhanLoaiPhongO.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }

            if (PrTab == "TabPhongO" && CurentTab == "TabSuKien")
            {
                NutHuyPhong.Enabled = true;

                ThanhPhanLoaiPhongO.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

                ThanhPhanLoaiSuKien.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
        }

        public void BangSuKienLoading()
        {
            Save = PhongDatHandle.LoadDataTable(TimeLine, KhachHang, PhongNghi, LoaiHinh, TrangThai);

            BangSuKien.DataSource = Save;

            BangSuKien.ClearSelection();
        }

        public void LoadThongSoPhong()
        {
            TongPhong_SE.Value = PhongNghiHandle.TongPhong();

            DangCoSan_SE.Value = PhongNghiHandle.DangCoSan();

            DaCoNguoi_SE.Value = PhongNghiHandle.DaCoNguoi();

            DaDuocDat_SE.Value = PhongNghiHandle.DaDuocDat();

            DangNgung_SE.Value = PhongNghiHandle.DangNgung();
        }

        private void DatPhongHienTai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhongNghi_SLUE.EditValue = PHONGNGHI;

            TimeLine_CBB.EditValue = "ALL";

            TrangThai_SLUE.EditValue = "RESERVED";

            PhanTrang.SelectedTabPage = TabSuKien;
        }

        private void NhatKyDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhongNghi_SLUE.EditValue = PHONGNGHI;

            TimeLine_CBB.EditValue = "ALL";

            TrangThai_SLUE.EditValue = null;

            PhanTrang.SelectedTabPage = TabSuKien;
        }

        private void LayPhongHienTai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhongNghi_SLUE.EditValue = PHONGNGHI;

            TimeLine_CBB.EditValue = "ALL";

            TrangThai_SLUE.EditValue = "CHECKEDIN";

            PhanTrang.SelectedTabPage = TabSuKien;
        }

        private void DinhDangKhungThongBao_BeforeFormShow(object sender, AlertFormEventArgs e)

                                                     => e.AlertForm.Size = new Size(450, 150);

    }
}