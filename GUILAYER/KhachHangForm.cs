using DATALAYER;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class KhachHangForm : DevExpress.XtraEditors.XtraForm
    {
        public KhachHangForm()
        {
            HamChucNang.BangKhachHang += DataLoading;

            InitializeComponent();
        }

        QuocTichBackend QuocTichHandle = new QuocTichBackend();

        GioiTinhBackend GioiTinhHandle = new GioiTinhBackend();

        KhachHangBackend KhachHandle = new KhachHangBackend();

        String GioiTinh;

        String QuocTich;

        List<KhachHangCustom> Save;

        public void DataLoading()
        {
            Save = KhachHandle.LoadDataTable(GioiTinh, QuocTich);

            BangDuLieu.DataSource = Save;

            BangDuLieu.ClearSelection();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            GioiTinh_SLUE.Properties.DataSource = GioiTinhHandle.LoadDataTable();

            QuocTich_SLUE.Properties.DataSource = QuocTichHandle.LoadDataTable();

            DataLoading();
        }

        private void SearchKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String Text = KhachSearch.Text.Trim();

                List<KhachHangCustom> Value = KhachHandle.SearchKhach(Text);

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

        private void GioiTinh_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = GioiTinh_SLUE.EditValue;

            GioiTinh = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void QuocTich_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = QuocTich_SLUE.EditValue;

            QuocTich = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinKhachHang ThemKhach = new ThongTinKhachHang(true);

            if (ThemKhach.ShowDialog() == DialogResult.OK)
            {
                KHACHHANG_TBL Value = ThemKhach.GetDataFromInfoForm();

                KhachHandle.Add(Value);

                DataLoading();
            }
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinKhachHang SuaKhach = new ThongTinKhachHang(false);

            SuaKhach.FillDataForInfoForm(BangDuLieu.SelectedRows[0]);

            if (SuaKhach.ShowDialog() == DialogResult.OK)
            {
                KHACHHANG_TBL Value = SuaKhach.GetDataFromInfoForm();

                KhachHandle.Edit(Value);

                DataLoading();
            }
        }

        private void BangDuLieu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo H = BangDuLieu.HitTest(e.X, e.Y);

                BangDuLieu.ClearSelection();

                if (H.RowIndex >= 0)
                {
                    BangDuLieu.Rows[H.RowIndex].Selected = true;

                    BangTuyChonKhach.ShowPopup(Cursor.Position);
                }
            }
        }
    }
}