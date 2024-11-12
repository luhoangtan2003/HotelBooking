using DATALAYER;
using DevExpress.XtraBars.Alerter;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class NhanPhongForm : DevExpress.XtraEditors.XtraForm
    {
        public NhanPhongForm()
        {
            HamChucNang.CheckInOut += BangKhachHangLoading;

            InitializeComponent();
        }

        readonly KhachHangBackend KhachHangHandle = new();

        readonly PhongDatBackend PhongDatHandle = new();

        readonly PhongNghiBackend PhongNghiHandle = new();

        String TrangThai;

        private void FormLoad(object sender, EventArgs e)
        {
            BangKhachHangLoading();
        }

        private void TrangThai_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_RG.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            BangKhachHangLoading();
        }

        private void BangKhach_SelectionChanged(object sender, EventArgs e)
        {
            if (BangKhachDat.SelectedRows.Count > 0)
            {
                DataGridViewCell Cell = BangKhachDat.SelectedRows[0].Cells["IDKHACH"];

                String ID = Cell.Value.ToString();

                BangDatPhong.DataSource = PhongDatHandle.LoadDataTable(ID, TrangThai);

                NutLayPhong.Enabled = PhongDatHandle.CoPhongDangDat(ID);

                LayPhongPopOn.Enabled = NutLayPhong.Enabled;

                NutHuyPhong.Enabled = PhongDatHandle.CoPhongDangDat(ID);

                HuyPhongPopOn.Enabled = NutHuyPhong.Enabled;

                NutTraPhong.Enabled = PhongDatHandle.CoPhongDangLay(ID);

                TraPhongPopOn.Enabled = NutTraPhong.Enabled;
            }
        }

        private void BangKhachHangLoading()
        {
            BangKhachDat.DataSource = KhachHangHandle.GetBookingOrCheckedIn(TrangThai);

            LoadThongSoPhong();
        }

        private void BangKhachDat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo HTI = BangKhachDat.HitTest(e.X, e.Y);

                BangKhachDat.ClearSelection();

                if (HTI.RowIndex >= 0)
                {
                    BangKhachDat.Rows[HTI.RowIndex].Selected = true;

                    BangTuyChonKhachHang.ShowPopup(Cursor.Position);
                }
            }
        }

        private void KhachDataSourceChanged(object sender, EventArgs e)
        {
            if (BangKhachDat.Rows.Count == 0)
            {
                BangDatPhong.DataSource = new List<DatPhongOCustom>();

                NutLayPhong.Enabled = false;

                NutHuyPhong.Enabled = false;

                NutTraPhong.Enabled = false;
            }
        }

        public void LoadThongSoPhong()
        {
            SoPhongCho_SE.Value = PhongNghiHandle.DaDuocDat();

            SoDangDung_SE.Value = PhongNghiHandle.DaCoNguoi();

            TongPhong_SE.Value = PhongNghiHandle.CoRangBuoc();
        }

        private void NutLayPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BangKhachDat.SelectedRows.Count > 0)
            {
                Object GetRow = BangKhachDat.SelectedRows[0].Cells["IDKHACH"].Value;

                ThongTinNhanPhong NewNhanPhongForm = new ThongTinNhanPhong(GetRow);

                NewNhanPhongForm.ShowDialog();
            }
            else
            {
                HamChucNang.ShowError("Không thể lấy, chưa có hàng nào được chọn");
            }
        }

        private void NutHuyPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BangKhachDat.SelectedRows.Count > 0)
            {
                String GetMaKhach = BangKhachDat.SelectedRows[0].Cells["IDKHACH"].Value.ToString();

                String GetHoVaTen = BangKhachDat.SelectedRows[0].Cells["HOVATEN"].Value.ToString();

                if (HamChucNang.ShowAlert("Hủy toàn bộ phòng chờ của khách???") == DialogResult.OK)
                {
                    Boolean Has = PhongDatHandle.HuyTatCaPhongDangDat(GetMaKhach);

                    AlertInfo SetInfo;

                    if (Has)
                    {
                        String Message = $"ĐÃ HỦY TẤT CẢ CÁC PHÒNG ĐANG ĐẶT CỦA KHÁCH HÀNG {GetHoVaTen}";

                        SetInfo = new AlertInfo("THÔNG BÁO", Message, Properties.Resources.Cancellation);

                        HamChucNang.CapNhatBookPhong();

                        HamChucNang.CapNhatBangPhong();

                        BangKhachHangLoading();

                        HamChucNang.CapNhatBangHoaDonPhong();
                    }
                    else
                    {
                        String Message = $"KHÔNG THỂ HỦY BỞI VÌ KHÔNG CÓ PHÒNG ĐANG CHỜ CỦA {GetHoVaTen}";

                        SetInfo = new AlertInfo("THÔNG BÁO", Message, Properties.Resources.Unscheduled);
                    }

                    ThongBaoDatPhong.Show(Owner, SetInfo);
                }
            }
            else
            {
                HamChucNang.ShowError("Không thể hủy đặt phòng, chưa có hàng nào được chọn");
            }
        }

        private void NutTraPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BangKhachDat.SelectedRows.Count > 0)
            {
                Object GetRow = BangKhachDat.SelectedRows[0].Cells["IDKHACH"].Value;

                ThongTinTraPhongO NewTraPhongOForm = new ThongTinTraPhongO(GetRow);

                NewTraPhongOForm.ShowDialog();
            }
            else
            {
                HamChucNang.ShowError("Không thể lấy, chưa có hàng nào được chọn");
            }
        }

        private void DinhDangKhungThongBao_BeforeFormShow(object sender, AlertFormEventArgs e)

                                                     => e.AlertForm.Size = new Size(450, 150);
    }
}