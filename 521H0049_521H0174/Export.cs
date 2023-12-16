using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    public partial class Export : UserControl
    {
        private readonly ImportAndExport File = new ImportAndExport();
        public Export()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.ExportFileStudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.ExportFileCertificate();
        }
    }
}
