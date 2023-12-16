using _521H0049_521H0174.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    public partial class AddCetificate : Form
    {
        private Model1 dbContext;
        public AddCetificate()
        {
            InitializeComponent();
            dbContext = new Model1();
        }

        private void AddCetificate_Load(object sender, EventArgs e)
        {
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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Certificate selectedCertificate = dbContext.Certificates
            .FirstOrDefault(cr => cr.CertificateName.Equals(cbx_certificate.SelectedItem.ToString()));

            if (selectedCertificate != null)
            {
                var CertificateForStudent = new CertificateStudentList()
                {
                    StudentID = int.Parse(tbLStID.Text),
                    CertificateID = selectedCertificate.CertificateID
                };

                dbContext.CertificateStudentList.Add(CertificateForStudent);
                dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
    
}
