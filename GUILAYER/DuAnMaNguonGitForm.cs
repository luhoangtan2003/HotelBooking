﻿using LOGICLAYER;
using Microsoft.Web.WebView2.Core;
using System;
using System.Linq;

namespace GUILAYER
{
    public partial class DuAnMaNguonGitForm : DevExpress.XtraEditors.XtraForm
    {
        public DuAnMaNguonGitForm()
        {
            InitializeComponent();
        }

        private async void DuAnMaNguonGitForm_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CoreWebView2Environment.GetAvailableBrowserVersionString()))
            {
                await ThungChuaGit.EnsureCoreWebView2Async(null);

                String Url = "https://github.com/luhoangtan2003/HotelBooking";

                if (Uri.IsWellFormedUriString(Url, UriKind.Absolute) == true)
                {
                    ThungChuaGit.CoreWebView2.Navigate(Url);
                }
                else
                {
                    HamChucNang.ShowError("URL không hợp lệ.");
                }
            }
            else
            {
                HamChucNang.ShowError("Microsoft WebView2 chưa được cài đặt trên máy của bạn!!!");
            }
        }
    }
}