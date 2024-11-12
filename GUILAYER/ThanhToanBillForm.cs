using DATALAYER;
using DevExpress.XtraReports.UI;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThanhToanBillForm : DevExpress.XtraEditors.XtraForm
    {
        public ThanhToanBillForm()
        {
            InitializeComponent();

            HamChucNang.BangHoaDonDatDV += BangHoaDonDatDVLoading;

            HamChucNang.BangHoaDonPhong += BangHoaDonPhongLoading;

            HamChucNang.PhongDatPhong += PhongSLUELoading;

            HamChucNang.BangKhachHang += KhachSLUELoading;
        }

        readonly PaymentTimeBackend PaymentTimeHandle = new();

        readonly HoaDonPhongBackend HoaDonPhongHandle = new();

        readonly KhachHangBackend KhachHangHandle = new();

        readonly PhongNghiBackend PhongNghiHandle = new();

        readonly TrangThaiHDBackend TrangThaiHandle = new();

        List<HoaDonPhongCustom> Save;

        String TimeLine;

        String KhachHang;

        String PhongNghi;

        String ThoiDiem;

        String TrangThai;

        public void BangHoaDonPhongLoading()
        {
            Save = HoaDonPhongHandle.LoadDataTable(TimeLine, KhachHang, PhongNghi, ThoiDiem, TrangThai);

            BangHoaDonPhongO.DataSource = Save;

            BangHoaDonPhongO.ClearSelection();
        }

        public void BangHoaDonDatDVLoading()
        {
            //Tạm thời bỏ qua phần load này
        }

        public void PhongSLUELoading()
        {
            PhongNghi_SLUE.Properties.DataSource = PhongNghiHandle.LoadDataTable().ToList();
        }

        public void KhachSLUELoading()
        {
            KhachHang_SLUE.Properties.DataSource = KhachHangHandle.LoadDataTable().ToList();
        }

        private void NutIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object MaHoaDon = BangHoaDonPhongO.SelectedRows[0].Cells["MAHOADONHDPN"].Value;

            HoaDonPhongReport NewHoaDonPhongO = new HoaDonPhongReport(MaHoaDon.ToString());

            NewHoaDonPhongO.ShowRibbonPreview();
        }

        public void DataTableLoading()
        {
            BangHoaDonPhongLoading();

            BangHoaDonDatDVLoading();
        }

        private void ThanhToanBillForm_Load(object sender, EventArgs e)
        {
            DataTableLoading();

            PhongSLUELoading();

            KhachSLUELoading();

            PaymentTimes.Properties.DataSource = PaymentTimeHandle.LoadDataTable();

            TrangThai_SLUE.Properties.DataSource = TrangThaiHandle.LoadDataTable();
        }

        private void TimeLine_EditValueChanged(object sender, EventArgs e)
        {
            TimeLine = TimeLine_CBB.EditValue.ToString();

            DataTableLoading();
        }

        private void KhachHang_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = KhachHang_SLUE.EditValue;

            KhachHang = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void PhongNghi_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = PhongNghi_SLUE.EditValue;

            PhongNghi = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void ThoiDiem_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = PaymentTimes.EditValue;

            ThoiDiem = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void TrangThai_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_SLUE.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void HoaDonPhongSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<HoaDonPhongCustom> Value = HoaDonPhongHandle.SearchHoaDon(HoaDonSearch.Text.Trim());

                if (HamChucNang.IsFieldNull(Value))
                {
                    BangHoaDonPhongO.DataSource = Save;
                }
                else
                {
                    BangHoaDonPhongO.DataSource = Value;
                }
            }
        }

        private void BangHoaDonPhong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo H = BangHoaDonPhongO.HitTest(e.X, e.Y);

                BangHoaDonPhongO.ClearSelection();

                if (H.RowIndex >= 0)
                {
                    BangHoaDonPhongO.Rows[H.RowIndex].Selected = true;

                    BangTuyChonHoaDonPhong.ShowPopup(Cursor.Position);
                }
            }
        }
    }
}