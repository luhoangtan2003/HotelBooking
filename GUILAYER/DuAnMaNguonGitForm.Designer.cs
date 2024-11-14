namespace GUILAYER
{
    partial class DuAnMaNguonGitForm
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
            this.ThungChuaGit = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.ThungChuaGit)).BeginInit();
            this.SuspendLayout();
            // 
            // ThungChuaGit
            // 
            this.ThungChuaGit.AllowExternalDrop = true;
            this.ThungChuaGit.CreationProperties = null;
            this.ThungChuaGit.DefaultBackgroundColor = System.Drawing.Color.White;
            this.ThungChuaGit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThungChuaGit.Location = new System.Drawing.Point(0, 0);
            this.ThungChuaGit.Name = "ThungChuaGit";
            this.ThungChuaGit.Size = new System.Drawing.Size(1883, 741);
            this.ThungChuaGit.TabIndex = 0;
            this.ThungChuaGit.ZoomFactor = 1D;
            // 
            // DuAnMaNguonGitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 741);
            this.Controls.Add(this.ThungChuaGit);
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.Name = "DuAnMaNguonGitForm";
            this.Text = "MÃ NGUỒN";
            this.Load += new System.EventHandler(this.DuAnMaNguonGitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThungChuaGit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 ThungChuaGit;
    }
}