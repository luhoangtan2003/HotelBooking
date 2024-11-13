using LOGICLAYER;
using Microsoft.Web.WebView2.Core;
using System;
using System.Linq;

namespace GUILAYER
{
    public partial class QuanLyMailboxForm : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyMailboxForm()
        {
            InitializeComponent();
        }

        private async void QuanLyMailboxForm_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CoreWebView2Environment.GetAvailableBrowserVersionString()))
            {
                await Mailbox.EnsureCoreWebView2Async(null);

                String PathMail = "https://mail.google.com";

                if (Uri.IsWellFormedUriString(PathMail, UriKind.Absolute))
                {
                    Mailbox.CoreWebView2.Navigate(PathMail);
                }
                else
                {
                    HamChucNang.ShowError("Đường dẫn url của bạn bị lỗi");

                    Close();
                }
            }
            else
            {
                HamChucNang.ShowError("Microsoft WebView2 chưa được cài đặt trên máy của bạn!!!");
            }
        }
    }
}