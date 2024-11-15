namespace GUILAYER
{
    partial class ThongTinNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinNguoiDung));
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.NutHuy = new DevExpress.XtraEditors.SimpleButton();
            this.NutOK = new DevExpress.XtraEditors.SimpleButton();
            this.AllowChange = new DevExpress.XtraEditors.ToggleSwitch();
            this.MailPassword = new DevExpress.XtraEditors.TextEdit();
            this.MailUsername = new DevExpress.XtraEditors.TextEdit();
            this.GetHotNumber = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Logo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetHotNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(12, 207);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(110, 26);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Username";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(12, 270);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(102, 26);
            this.LabelControl2.TabIndex = 1;
            this.LabelControl2.Text = "Password";
            // 
            // NutHuy
            // 
            this.NutHuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NutHuy.Appearance.Options.UseFont = true;
            this.NutHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NutHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NutHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutHuy.ImageOptions.SvgImage")));
            this.NutHuy.Location = new System.Drawing.Point(309, 328);
            this.NutHuy.Name = "NutHuy";
            this.NutHuy.Size = new System.Drawing.Size(94, 46);
            this.NutHuy.TabIndex = 8;
            this.NutHuy.Text = "HỦY";
            // 
            // NutOK
            // 
            this.NutOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NutOK.Appearance.Options.UseFont = true;
            this.NutOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NutOK.Enabled = false;
            this.NutOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutOK.ImageOptions.SvgImage")));
            this.NutOK.Location = new System.Drawing.Point(421, 328);
            this.NutOK.Name = "NutOK";
            this.NutOK.Size = new System.Drawing.Size(94, 46);
            this.NutOK.TabIndex = 7;
            this.NutOK.Text = "OK";
            this.NutOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // AllowChange
            // 
            this.AllowChange.Location = new System.Drawing.Point(12, 337);
            this.AllowChange.Name = "AllowChange";
            this.AllowChange.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowChange.Properties.Appearance.Options.UseFont = true;
            this.AllowChange.Properties.OffText = "Off";
            this.AllowChange.Properties.OnText = "On";
            this.AllowChange.Size = new System.Drawing.Size(161, 33);
            this.AllowChange.TabIndex = 10;
            this.AllowChange.EditValueChanged += new System.EventHandler(this.AllowChange_EditValueChanged);
            // 
            // MailPassword
            // 
            this.MailPassword.Enabled = false;
            this.MailPassword.Location = new System.Drawing.Point(145, 267);
            this.MailPassword.Name = "MailPassword";
            this.MailPassword.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailPassword.Properties.Appearance.Options.UseFont = true;
            this.MailPassword.Size = new System.Drawing.Size(370, 32);
            this.MailPassword.TabIndex = 6;
            // 
            // MailUsername
            // 
            this.MailUsername.Enabled = false;
            this.MailUsername.Location = new System.Drawing.Point(145, 204);
            this.MailUsername.Name = "MailUsername";
            this.MailUsername.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailUsername.Properties.Appearance.Options.UseFont = true;
            this.MailUsername.Size = new System.Drawing.Size(370, 32);
            this.MailUsername.TabIndex = 4;
            // 
            // GetHotNumber
            // 
            this.GetHotNumber.Enabled = false;
            this.GetHotNumber.Location = new System.Drawing.Point(145, 146);
            this.GetHotNumber.Name = "GetHotNumber";
            this.GetHotNumber.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetHotNumber.Properties.Appearance.Options.UseFont = true;
            this.GetHotNumber.Size = new System.Drawing.Size(370, 32);
            this.GetHotNumber.TabIndex = 12;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(12, 149);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(118, 26);
            this.LabelControl3.TabIndex = 11;
            this.LabelControl3.Text = "Điện Thoại";
            // 
            // Logo
            // 
            this.Logo.EditValue = global::GUILAYER.Properties.Resources.User;
            this.Logo.Location = new System.Drawing.Point(215, 10);
            this.Logo.Name = "Logo";
            this.Logo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Logo.Properties.Appearance.Options.UseBackColor = true;
            this.Logo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Logo.Size = new System.Drawing.Size(100, 100);
            this.Logo.TabIndex = 15;
            // 
            // ThongTinNguoiDung
            // 
            this.AcceptButton = this.NutOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NutHuy;
            this.ClientSize = new System.Drawing.Size(530, 393);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.GetHotNumber);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.AllowChange);
            this.Controls.Add(this.NutHuy);
            this.Controls.Add(this.NutOK);
            this.Controls.Add(this.MailPassword);
            this.Controls.Add(this.MailUsername);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongTinNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllowChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetHotNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private DevExpress.XtraEditors.LabelControl LabelControl2;
        private DevExpress.XtraEditors.TextEdit MailUsername;
        private DevExpress.XtraEditors.TextEdit MailPassword;
        private DevExpress.XtraEditors.SimpleButton NutHuy;
        private DevExpress.XtraEditors.SimpleButton NutOK;
        private DevExpress.XtraEditors.ToggleSwitch AllowChange;
        private DevExpress.XtraEditors.TextEdit GetHotNumber;
        private DevExpress.XtraEditors.LabelControl LabelControl3;
        private DevExpress.XtraEditors.PictureEdit Logo;
    }
}