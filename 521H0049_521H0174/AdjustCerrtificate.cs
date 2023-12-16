using _521H0049_521H0174.Models;
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
    public partial class AdjustCerrtificate : Form
    {
        public int _CertificateStudentid { get; set; }
        private Model1 dbContext;
        public AdjustCerrtificate()
        {
            InitializeComponent();
            dbContext = new Model1();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            int? Id = int.TryParse(id.Text, out int parsedId) ? parsedId : (int?)null;
            var certificateStudentData = dbContext.CertificateStudentList.FirstOrDefault(cs => cs.Id == Id);
            certificateStudentData.Certificate.CertificateName = cbx_certificate.SelectedItem.ToString();

            var Cer = dbContext.Certificates.FirstOrDefault(d => d.CertificateName == certificateStudentData.Certificate.CertificateName);
            certificateStudentData.CertificateID = Cer.CertificateID;
            DialogResult = DialogResult.OK;
            dbContext.SaveChangesAsync();
            Close();
        }

        private void AdjustCerrtificate_Load(object sender, EventArgs e)
        {
            id.Text = _CertificateStudentid.ToString();
            var certificates = dbContext.Certificates.ToList();
            if (certificates.Count == 0)
            {
                List<string> sampleData = new List<string>
                {
                    "TOEIC",
                    "TOEFL",
                    "IELTS",
                    "CEFR",
                    "SAT",
                    "TESOL"
                };
                foreach (var data in sampleData)
                {
                    Certificate certificate = new Certificate
                    {
                        CertificateName = data
                    };

                    dbContext.Certificates.Add(certificate);
                    dbContext.SaveChanges();
                }
            }

            foreach (var certificate in dbContext.Certificates)
            {
                cbx_certificate.Items.Add(certificate.CertificateName);
            }

            var certificateStudentData = dbContext.CertificateStudentList.FirstOrDefault(cs => cs.Id == _CertificateStudentid);
            if (certificateStudentData != null)
            {
                var student = dbContext.Students.FirstOrDefault(cs => cs.StudentID == certificateStudentData.StudentID);
                tb_fullname.Text = student.FirstName + " " + student.LastName;
            }
            id.Enabled = false;
            tb_fullname.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
