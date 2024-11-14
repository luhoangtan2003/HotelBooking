namespace GUILAYER
{
    partial class ThongKeDuLieuTheoM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDuLieuTheoM));
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ToggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.NamThongKe = new DevExpress.XtraEditors.SpinEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PhanTrang = new DevExpress.XtraTab.XtraTabControl();
            this.TrangThongKeHoaDonPhongO = new DevExpress.XtraTab.XtraTabPage();
            this.BieuDoPhongO = new DevExpress.XtraCharts.ChartControl();
            this.TrangThongKeHoaDonDichVu = new DevExpress.XtraTab.XtraTabPage();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamThongKe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhanTrang)).BeginInit();
            this.PhanTrang.SuspendLayout();
            this.TrangThongKeHoaDonPhongO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoPhongO)).BeginInit();
            this.TrangThongKeHoaDonDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Controls.Add(this.PanelControl1, 0, 0);
            this.LayoutPanel.Controls.Add(this.PanelControl2, 0, 1);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 2;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.16321F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.83678F));
            this.LayoutPanel.Size = new System.Drawing.Size(1633, 741);
            this.LayoutPanel.TabIndex = 0;
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.ToggleSwitch);
            this.PanelControl1.Controls.Add(this.NamThongKe);
            this.PanelControl1.Controls.Add(this.LabelControl1);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl1.Location = new System.Drawing.Point(3, 3);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1627, 69);
            this.PanelControl1.TabIndex = 0;
            // 
            // ToggleSwitch
            // 
            this.ToggleSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleSwitch.Location = new System.Drawing.Point(1416, 19);
            this.ToggleSwitch.Name = "ToggleSwitch";
            this.ToggleSwitch.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleSwitch.Properties.Appearance.Options.UseFont = true;
            this.ToggleSwitch.Properties.OffText = "2D Chart";
            this.ToggleSwitch.Properties.OnText = "3D Chart";
            this.ToggleSwitch.Size = new System.Drawing.Size(206, 33);
            this.ToggleSwitch.TabIndex = 2;
            this.ToggleSwitch.EditValueChanged += new System.EventHandler(this.BieuDoPhong_EditValueChanged);
            // 
            // NamThongKe
            // 
            this.NamThongKe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamThongKe.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NamThongKe.Location = new System.Drawing.Point(478, 19);
            this.NamThongKe.Name = "NamThongKe";
            this.NamThongKe.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamThongKe.Properties.Appearance.Options.UseFont = true;
            this.NamThongKe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NamThongKe.Properties.IsFloatValue = false;
            this.NamThongKe.Properties.MaskSettings.Set("mask", "N00");
            this.NamThongKe.Size = new System.Drawing.Size(117, 32);
            this.NamThongKe.TabIndex = 1;
            this.NamThongKe.EditValueChanged += new System.EventHandler(this.NamThongKe_EditValueChanged);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(5, 22);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(467, 26);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU NĂM";
            // 
            // PanelControl2
            // 
            this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl2.Controls.Add(this.PhanTrang);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl2.Location = new System.Drawing.Point(3, 78);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(1627, 660);
            this.PanelControl2.TabIndex = 1;
            // 
            // PhanTrang
            // 
            this.PhanTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhanTrang.Location = new System.Drawing.Point(0, 0);
            this.PhanTrang.Name = "PhanTrang";
            this.PhanTrang.SelectedTabPage = this.TrangThongKeHoaDonPhongO;
            this.PhanTrang.Size = new System.Drawing.Size(1627, 660);
            this.PhanTrang.TabIndex = 0;
            this.PhanTrang.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TrangThongKeHoaDonPhongO,
            this.TrangThongKeHoaDonDichVu});
            // 
            // TrangThongKeHoaDonPhongO
            // 
            this.TrangThongKeHoaDonPhongO.Appearance.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TrangThongKeHoaDonPhongO.Appearance.HeaderActive.Options.UseFont = true;
            this.TrangThongKeHoaDonPhongO.Controls.Add(this.BieuDoPhongO);
            this.TrangThongKeHoaDonPhongO.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TrangThongKeHoaDonPhongO.ImageOptions.SvgImage")));
            this.TrangThongKeHoaDonPhongO.Name = "TrangThongKeHoaDonPhongO";
            this.TrangThongKeHoaDonPhongO.Size = new System.Drawing.Size(1625, 602);
            this.TrangThongKeHoaDonPhongO.Text = "PHÒNG Ở";
            // 
            // BieuDoPhongO
            // 
            this.BieuDoPhongO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BieuDoPhongO.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.BieuDoPhongO.CrosshairOptions.ShowArgumentLine = false;
            this.BieuDoPhongO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BieuDoPhongO.Location = new System.Drawing.Point(0, 0);
            this.BieuDoPhongO.Name = "BieuDoPhongO";
            this.BieuDoPhongO.PaletteName = "Office 2013";
            this.BieuDoPhongO.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.BieuDoPhongO.Size = new System.Drawing.Size(1625, 602);
            this.BieuDoPhongO.TabIndex = 0;
            // 
            // TrangThongKeHoaDonDichVu
            // 
            this.TrangThongKeHoaDonDichVu.Appearance.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TrangThongKeHoaDonDichVu.Appearance.HeaderActive.Options.UseFont = true;
            this.TrangThongKeHoaDonDichVu.Controls.Add(this.LabelControl2);
            this.TrangThongKeHoaDonDichVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TrangThongKeHoaDonDichVu.ImageOptions.SvgImage")));
            this.TrangThongKeHoaDonDichVu.Name = "TrangThongKeHoaDonDichVu";
            this.TrangThongKeHoaDonDichVu.Size = new System.Drawing.Size(1625, 602);
            this.TrangThongKeHoaDonDichVu.Text = "DỊCH VỤ";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(548, 287);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(510, 26);
            this.LabelControl2.TabIndex = 1;
            this.LabelControl2.Text = "CHỨC NĂNG NÀY CHƯA ĐƯỢC XÂY DỰNG";
            // 
            // ThongKeDuLieuTheoM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutPanel);
            this.Name = "ThongKeDuLieuTheoM";
            this.Size = new System.Drawing.Size(1633, 741);
            this.Load += new System.EventHandler(this.BieuDoThongKeDuLieu_Loading);
            this.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamThongKe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhanTrang)).EndInit();
            this.PhanTrang.ResumeLayout(false);
            this.TrangThongKeHoaDonPhongO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoPhongO)).EndInit();
            this.TrangThongKeHoaDonDichVu.ResumeLayout(false);
            this.TrangThongKeHoaDonDichVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private DevExpress.XtraEditors.PanelControl PanelControl1;
        private DevExpress.XtraEditors.PanelControl PanelControl2;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private DevExpress.XtraEditors.SpinEdit NamThongKe;
        private DevExpress.XtraTab.XtraTabControl PhanTrang;
        private DevExpress.XtraTab.XtraTabPage TrangThongKeHoaDonPhongO;
        private DevExpress.XtraTab.XtraTabPage TrangThongKeHoaDonDichVu;
        private DevExpress.XtraEditors.ToggleSwitch ToggleSwitch;
        private DevExpress.XtraCharts.ChartControl BieuDoPhongO;
        private DevExpress.XtraEditors.LabelControl LabelControl2;
    }
}
