using LOGICLAYER;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinNguoiDung()
        {
            InitializeComponent();
        }

        public void Account_Load()
        {
            MailUsername.Text = Environment.GetEnvironmentVariable("MailUsername", EnvironmentVariableTarget.User);

            MailPassword.Text = Environment.GetEnvironmentVariable("MailPassword", EnvironmentVariableTarget.User);

            GetHotNumber.Text = Environment.GetEnvironmentVariable("PhoneNumber", EnvironmentVariableTarget.User);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Account_Load();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (HamChucNang.ShowAlert("Bạn có muốn thay đổi thông tin tài khoản?") == DialogResult.OK)
            {
                Environment.SetEnvironmentVariable("MailUsername", MailUsername.Text.Trim(), EnvironmentVariableTarget.User);

                Environment.SetEnvironmentVariable("MailPassword", MailPassword.Text.Trim(), EnvironmentVariableTarget.User);

                Environment.SetEnvironmentVariable("PhoneNumber", GetHotNumber.Text.Trim(), EnvironmentVariableTarget.User);

                Account_Load();
            }
            else
            {
                Account_Load();
            }
        }

        private void AllowChange_EditValueChanged(object sender, EventArgs e)
        {
            if (AllowChange.IsOn)
            {
                NutOK.Enabled = true;

                MailUsername.Enabled = true;

                MailPassword.Enabled = true;

                GetHotNumber.Enabled = true;
            }
            else
            {
                NutOK.Enabled = false;

                MailUsername.Enabled = false;

                MailPassword.Enabled = false;

                GetHotNumber.Enabled = false;
            }
        }
    }
}