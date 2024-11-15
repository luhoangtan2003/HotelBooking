using DATALAYER;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class DichVuKhachHangForm : DevExpress.XtraEditors.XtraForm
    {
        public DichVuKhachHangForm()
        {
            HamChucNang.BangDichVu += DataLoading;

            InitializeComponent();
        }

        readonly LoaiDichVuBackend LoaiDVHandle = new();

        readonly LoaiHinhDVBackend LoaiHinhDVHandle = new();

        readonly DichVuBackend DichVuHandle = new();

        readonly TrangThaiDVBackend TrangThaiHandle = new();

        List<DichVuCustom> Save;

        String TrangThai;

        String LoaiHinh;

        String LoaiDichVu;

        public void DataLoading()
        {
            Save = DichVuHandle.LoadDataTable(LoaiDichVu, LoaiHinh, TrangThai);

            BangDuLieu.DataSource = Save;

            BangDuLieu.ClearSelection();
        }

        private void DichVuForm_Load(object sender, EventArgs e)
        {
            TrangThai_SLUE.Properties.DataSource = TrangThaiHandle.LoadDataTable();

            LoaiDichVu_SLUE.Properties.DataSource = LoaiDVHandle.LoadDataTable();

            LoaiHinh_SLUE.Properties.DataSource = LoaiHinhDVHandle.LoadDataTable();

            DataLoading();
        }

        private void LoaiHinh_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = LoaiHinh_SLUE.EditValue;

            LoaiHinh = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void TrangThai_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_SLUE.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void LoaiDichVu_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = LoaiDichVu_SLUE.EditValue;

            LoaiDichVu = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinDichVuKS ThemDichVu = new ThongTinDichVuKS(true);

            if (ThemDichVu.ShowDialog() == DialogResult.OK)
            {
                DICHVU_TBL Value = ThemDichVu.GetDataFromInfoForm();

                DichVuHandle.Add(Value);

                DataLoading();

                HamChucNang.CapNhatBangLoaiDV();
            }
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinDichVuKS SuaDichVu = new ThongTinDichVuKS(false);

            DataGridViewRow Focus = BangDuLieu.SelectedRows[0];

            SuaDichVu.FillDataForInfoForm(Focus);

            if (SuaDichVu.ShowDialog() == DialogResult.OK)
            {
                DICHVU_TBL Value = SuaDichVu.GetDataFromInfoForm();

                DichVuHandle.Edit(Value);

                DataLoading();

                HamChucNang.CapNhatBangLoaiDV();
            }
        }

        private void NutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String GetMaDichVu = BangDuLieu.SelectedRows[0].Cells["MADICHVU"].Value.ToString();

            DichVuHandle.Remove(GetMaDichVu);

            DataLoading();

            HamChucNang.CapNhatBangLoaiDV();
        }

        private void BangDuLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (BangDuLieu.SelectedRows.Count > 0)
            {
                DataGridViewRow GetRow = BangDuLieu.SelectedRows[0];

                String MaDichVu = GetRow.Cells["MADICHVU"].Value.ToString();

                if (DichVuHandle.Referenced(MaDichVu))
                {
                    NutXoa.Enabled = false;
                }
                else
                {
                    NutXoa.Enabled = true;
                }

                NutSua.Enabled = true;
            }
            else
            {
                NutXoa.Enabled = false;

                NutSua.Enabled = false;
            }
        }

        private void SearchDichVuKS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String Text = DichVuSearch.Text.Trim();

                List<DichVuCustom> Value = DichVuHandle.SearchDichVu(Text);

                if (HamChucNang.IsFieldNull(Value))
                {
                    BangDuLieu.DataSource = Save;
                }
                else
                {
                    BangDuLieu.DataSource = Value;
                }
            }
        }
    }
}