namespace GUILAYER
{
    partial class HuongDanForm
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
            this.PDF = new DevExpress.XtraPdfViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // PDF
            // 
            this.PDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDF.Location = new System.Drawing.Point(0, 0);
            this.PDF.Name = "PDF";
            this.PDF.ReadOnly = true;
            this.PDF.Size = new System.Drawing.Size(1883, 741);
            this.PDF.TabIndex = 0;
            // 
            // HuongDanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 741);
            this.Controls.Add(this.PDF);
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.LogoHotel;
            this.Name = "HuongDanForm";
            this.Text = "GIỚI THIỆU VÀ HƯỚNG DẪN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HuongDanForm_Closed);
            this.Load += new System.EventHandler(this.Loading);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer PDF;
    }
}