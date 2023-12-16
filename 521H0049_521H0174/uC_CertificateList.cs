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

        public uC_CertificateList()
        {
            InitializeComponent();
            dbContext = new Model1();
            DGV_studentData.DataSource = dbContext.Students.ToList();
           // DGV_CM.DataSource = dbContext.CertificateStudentList.
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
                        CertificateID = cs.CertificateID,
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

        }
    }
}
