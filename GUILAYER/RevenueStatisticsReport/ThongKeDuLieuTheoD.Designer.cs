namespace GUILAYER
{
    partial class ThongKeDuLieuTheoD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDuLieuTheoD));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ThangThongKe = new DevExpress.XtraEditors.SpinEdit();
            this.ToggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.NamThongKe = new DevExpress.XtraEditors.SpinEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PhanTrang = new DevExpress.XtraTab.XtraTabControl();
            this.TrangThongKeHoaDonPhongO = new DevExpress.XtraTab.XtraTabPage();
            this.BieuDoPhongO = new DevExpress.XtraCharts.ChartControl();
            this.TrangThongKeHoaDonDichVu = new DevExpress.XtraTab.XtraTabPage();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThangThongKe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamThongKe.Properties)).BeginInit();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhanTrang)).BeginInit();
            this.PhanTrang.SuspendLayout();
            this.TrangThongKeHoaDonPhongO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoPhongO)).BeginInit();
            this.TrangThongKeHoaDonDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.labelControl2);
            this.PanelControl1.Controls.Add(this.ThangThongKe);
            this.PanelControl1.Controls.Add(this.ToggleSwitch);
            this.PanelControl1.Controls.Add(this.NamThongKe);
            this.PanelControl1.Controls.Add(this.LabelControl1);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl1.Location = new System.Drawing.Point(3, 3);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1627, 69);
            this.PanelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(631, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 26);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "NĂM";
            // 
            // ThangThongKe
            // 
            this.ThangThongKe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThangThongKe.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ThangThongKe.Location = new System.Drawing.Point(508, 19);
            this.ThangThongKe.Name = "ThangThongKe";
            this.ThangThongKe.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThangThongKe.Properties.Appearance.Options.UseFont = true;
            this.ThangThongKe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ThangThongKe.Properties.IsFloatValue = false;
            this.ThangThongKe.Properties.MaskSettings.Set("mask", "N00");
            this.ThangThongKe.Size = new System.Drawing.Size(117, 32);
            this.ThangThongKe.TabIndex = 3;
            this.ThangThongKe.EditValueChanged += new System.EventHandler(this.ThangThongKe_EditValueChanged);
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
            this.ToggleSwitch.EditValueChanged += new System.EventHandler(this.ToggleSwitch_EditValueChanged);
            // 
            // NamThongKe
            // 
            this.NamThongKe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamThongKe.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NamThongKe.Location = new System.Drawing.Point(694, 19);
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
            this.LabelControl1.Size = new System.Drawing.Size(497, 26);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU THÁNG";
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
            this.LayoutPanel.TabIndex = 1;
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
            this.TrangThongKeHoaDonDichVu.Controls.Add(this.LabelControl3);
            this.TrangThongKeHoaDonDichVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TrangThongKeHoaDonDichVu.ImageOptions.SvgImage")));
            this.TrangThongKeHoaDonDichVu.Name = "TrangThongKeHoaDonDichVu";
            this.TrangThongKeHoaDonDichVu.Size = new System.Drawing.Size(1625, 602);
            this.TrangThongKeHoaDonDichVu.Text = "DỊCH VỤ";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(548, 287);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(510, 26);
            this.LabelControl3.TabIndex = 1;
            this.LabelControl3.Text = "CHỨC NĂNG NÀY CHƯA ĐƯỢC XÂY DỰNG";
            // 
            // ThongKeDuLieuTheoD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutPanel);
            this.Name = "ThongKeDuLieuTheoD";
            this.Size = new System.Drawing.Size(1633, 741);
            this.Load += new System.EventHandler(this.BieuDoThongKeDuLieu_Loading);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThangThongKe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamThongKe.Properties)).EndInit();
            this.LayoutPanel.ResumeLayout(false);
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

        private DevExpress.XtraEditors.PanelControl PanelControl1;
        private DevExpress.XtraEditors.ToggleSwitch ToggleSwitch;
        private DevExpress.XtraEditors.SpinEdit NamThongKe;
        private DevExpress.XtraEditors.LabelControl LabelControl1;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private DevExpress.XtraEditors.PanelControl PanelControl2;
        private DevExpress.XtraTab.XtraTabControl PhanTrang;
        private DevExpress.XtraTab.XtraTabPage TrangThongKeHoaDonPhongO;
        private DevExpress.XtraCharts.ChartControl BieuDoPhongO;
        private DevExpress.XtraTab.XtraTabPage TrangThongKeHoaDonDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit ThangThongKe;
        private DevExpress.XtraEditors.LabelControl LabelControl3;
    }
}
