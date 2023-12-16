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
    public partial class uC_studentManageList : UserControl
    {
        private readonly myDAL myDal = new myDAL();
        public static uC_studentManageList instance;
        public string _instanceFName;
        public string _instanceLName;
        public string _instanceGender;
        public string _instanceStatus;
        public string _instancePhone;
        public int _instanceAge;
        public double _instanceGPA;
        private int firstSetup = -1;


        public uC_studentManageList()
        {
            InitializeComponent();
            instance = this;
            onStartForm();
        }

        private void onStartForm()
        {
            SetupGenderComboBox();
            SetupStatusComboBox();
            LoadStudentData();
            tbGPA.Text= string.Empty;
        }

        private void SetupStatusComboBox()
        {

            cbx_status.Items.Add("All");
            cbx_status.Items.Add("Enroll");
            cbx_status.Items.Add("Active");
            cbx_status.Items.Add("Graduated");
            cbx_status.Items.Add("Banned");

            cbx_status.SelectedIndex = 0; 
        }

        private void SetupGenderComboBox()
        {
            cbx_gender.Items.Add("All");
            cbx_gender.Items.Add("Male");
            cbx_gender.Items.Add("Female");

            cbx_gender.SelectedIndex = 0;
        }

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',') || (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(',')))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((TextBox)sender).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!IsUnder0(((TextBox)sender).Text))
                {
                    tbGPA.Text = "0,0";
                    e.Handled = true;
                }

                if (!IsOver4(((TextBox)sender).Text))
                {
                    tbGPA.Text = "4,0";
                    e.Handled = true;
                }
            }
        }

        private bool IsUnder0(string input)
        {
            if (double.TryParse(input, out double value))
            {
                return value >= 0.0;
            }

            return false;
        }

        private bool IsOver4(string input)
        {
            if (double.TryParse(input, out double value))
            {
                return  value <= 4.0;
            }

            return false;
        }

        private void LoadStudentData()
        {
            DGV_studentData.DataSource = myDal.GetAllStudent();
            DGV_studentData.Refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmAddStudent f = new frmAddStudent();

            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                LoadStudentData();
            }
        }

        private async void btn_adjust_Click(object sender, EventArgs e)
        {
            if (DGV_studentData.SelectedRows.Count > 0)
            {
                

                string fname, phone, status, lname,gender;
                int age, _id;
                double gpa;

                _id = int.Parse(DGV_studentData.SelectedRows[0].Cells["StudentID"].Value.ToString());
                fname = DGV_studentData.SelectedRows[0].Cells["FirstName"].Value.ToString();
                lname = DGV_studentData.SelectedRows[0].Cells["LastName"].Value.ToString();
                phone = DGV_studentData.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                age = int.Parse(DGV_studentData.SelectedRows[0].Cells["Age"].Value.ToString());
                gpa = double.Parse(DGV_studentData.SelectedRows[0].Cells["GPA"].Value.ToString());
                status = DGV_studentData.SelectedRows[0].Cells["Status"].Value.ToString();
                gender = DGV_studentData.SelectedRows[0].Cells["Gender"].Value.ToString();


                frmAdjustStudent stdAdjs = new frmAdjustStudent(fname, lname, phone, status, gender, age, gpa);

                if (stdAdjs.ShowDialog() == DialogResult.OK)
                {

                    Student updatedStudent = new Student
                    {
                        StudentID = _id,
                        FirstName = _instanceFName,
                        LastName = _instanceLName,
                        PhoneNumber = _instancePhone,
                        Age = _instanceAge,
                        Status = _instanceStatus,
                        Gender = _instanceGender,
                        GPA= _instanceGPA,
                    };

                    await myDal.UpdateStudent(updatedStudent);

                    LoadStudentData();
                }

            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (DGV_studentData.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int userIdToDelete = (int)DGV_studentData.SelectedRows[0].Cells["StudentID"].Value;
                    await myDal.DeleteStudent(userIdToDelete);

                    LoadStudentData();
                }
            }
        }

        private double? GetDoubleValue(string text)
        {
            if (double.TryParse(text, out double result))
            {
                return result;
            }
            return null;
        }

        private void genderChanged(object sender, EventArgs e)
        {
            if (firstSetup==0)
            {
                string selectedStatus = cbx_status.SelectedItem.ToString();
                string selectedGender = cbx_gender.SelectedItem.ToString();
                double? maxGPA = GetDoubleValue(tbGPA.Text);

                var filteredStudents = myDal.GetFilteredStudents(selectedStatus, selectedGender, maxGPA);
                DGV_studentData.DataSource = filteredStudents;
                DGV_studentData.Refresh();
            }
            else
            {
                firstSetup += 1;
            }
            
        }

        private void statusChanged(object sender, EventArgs e)
        {
            if (firstSetup == 0)
            {
                string selectedStatus = cbx_status.SelectedItem.ToString();
                string selectedGender = cbx_gender.SelectedItem.ToString();
                double? maxGPA = GetDoubleValue(tbGPA.Text);

                var filteredStudents = myDal.GetFilteredStudents(selectedStatus, selectedGender, maxGPA);
                DGV_studentData.DataSource = filteredStudents;
                DGV_studentData.Refresh();
            }
            else
            {
                firstSetup += 1;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (firstSetup == 0)
            {
                string selectedStatus = cbx_status.SelectedItem.ToString();
                string selectedGender = cbx_gender.SelectedItem.ToString();
                double? maxGPA = GetDoubleValue(tbGPA.Text);

                var filteredStudents = myDal.GetFilteredStudents(selectedStatus, selectedGender, maxGPA);
                DGV_studentData.DataSource = filteredStudents;
                DGV_studentData.Refresh();
            }
            else
            {
                firstSetup += 1;
            }
        }
    }
}
