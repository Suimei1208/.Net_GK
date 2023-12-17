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
    public partial class uC_CertificateList : UserControl
    {
        private Model1 dbContext;
        public int _CertificateStudentid { get; set; }
        public uC_CertificateList()
        {
            InitializeComponent();
            dbContext = new Model1();
            DGV_studentData.DataSource = dbContext.Students.ToList();
            // DGV_CM.DataSource = dbContext.CertificateStudentList.
            btn_add.Visible = false;
            btn_delete.Visible = false;
            btn_adjust.Visible = false;
            if (SharedData.Instance.Role.Equals("Admin"))
            {
                btn_add.Visible = true;
                btn_delete.Visible = true;
                btn_adjust.Visible = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (DGV_studentData.SelectedRows.Count > 0)
            {
               AddCetificate addCetificate = new AddCetificate();
                addCetificate.ShowDialog();
                if (addCetificate.DialogResult == DialogResult.OK)
                {
                    DGV_studentData.DataSource = dbContext.Students.ToList();
                }
            }
        }

        private void DGV_studentData_SelectionChanged(object sender, EventArgs e)
        {
            if(DGV_studentData.SelectedRows.Count > 0)
            {
                int id = (int)DGV_studentData.SelectedRows[0].Cells["StudentID"].Value;

                var certificateStudentData = dbContext.CertificateStudentList
                    .Where(cs => cs.StudentID == id)
                    .Select(cs => new
                    {
                        Id = cs.Id,
                        CertificateName = cs.Certificate.CertificateName,
                        StudentID = cs.StudentID,
                        StudentName = cs.Student.FirstName + " " + cs.Student.LastName
                    })
            .ToList();
                if (certificateStudentData != null)
                {
                    DGV_CM.DataSource = certificateStudentData;
                }
            }
        }

        private void btn_adjust_Click(object sender, EventArgs e)
        {
            _CertificateStudentid = (int)DGV_CM.SelectedRows[0].Cells["Id"].Value;

            AdjustCerrtificate adjustCerrtificate = new AdjustCerrtificate();
            adjustCerrtificate._CertificateStudentid = _CertificateStudentid;
            adjustCerrtificate.ShowDialog();   
            if(adjustCerrtificate.DialogResult == DialogResult.OK)
            {
                DGV_studentData.DataSource = dbContext.Students.ToList();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DGV_CM.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedId = (int)DGV_CM.SelectedRows[0].Cells["Id"].Value;
                    CertificateStudentList remove = dbContext.CertificateStudentList.FirstOrDefault(a => a.Id == selectedId);
                    if (remove != null)
                    {
                        dbContext.CertificateStudentList.Remove(remove);
                        dbContext.SaveChanges();
                    }
                }
            }
            DGV_studentData.DataSource = dbContext.Students.ToList();
        }
    }
}
