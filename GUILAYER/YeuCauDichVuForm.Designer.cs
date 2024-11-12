namespace GUILAYER
{
    partial class YeuCauDichVuForm
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
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(686, 357);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(510, 26);
            this.LabelControl2.TabIndex = 2;
            this.LabelControl2.Text = "CHỨC NĂNG NÀY CHƯA ĐƯỢC XÂY DỰNG";
            // 
            // YeuCauDichVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 741);
            this.Controls.Add(this.LabelControl2);
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.LogoHotel;
            this.Name = "YeuCauDichVuForm";
            this.Text = "ĐẶT DỊCH VỤ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LabelControl2;
    }
}