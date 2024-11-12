using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class HuongDanForm : DevExpress.XtraEditors.XtraForm
    {
        public HuongDanForm() { InitializeComponent(); }

        String TempFilePath;

        private void Loading(object sender, EventArgs e)
        {
            TempFilePath = Path.Combine(Path.GetTempPath(), "Introduction.PDF");

            File.WriteAllBytes(TempFilePath, Properties.Resources.Introduction);

            PDF.LoadDocument(TempFilePath);
        }

        private void HuongDanForm_Closed(object sender, FormClosedEventArgs e)
        {
            PDF.CloseDocument();

            File.Delete(TempFilePath);
        }
    }
}