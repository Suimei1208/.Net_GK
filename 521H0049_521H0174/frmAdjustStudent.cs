using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    public partial class frmAdjustStudent : Form
    {
        private string _fname;
        private string _lname;
        private string _phone;
        private string _status;
        private string _gender;
        private int _age;
        private double _gpa;

        public frmAdjustStudent(string Fname, string Lname, string phone, string status, string gender, int age, double gpa)
        {
            InitializeComponent();
            syncData(Fname,Lname,phone,status,gender,age,gpa);
            SetupStatusComboBox();
            SetupGenderComboBox();
            setDataToAdjust();
        }

        private void syncData(string Fname, string Lname, string phone, string status, string gender, int age, double gpa)
        {
            _fname= Fname;
            _lname= Lname;
            _phone= phone;
            _status= status;
            _gender=gender;
            _age= age;
            _gpa=gpa;

        }

        private void setDataToAdjust()
        {
            tbFName.Text = _fname;
            tbLName.Text = _lname;
            tbPhoneNumber.Text = _phone;
            tbAge.Text = _age + "";
            tbGPA.Text = _gpa + "";
            cbx_gender.SelectedItem = _gender;
            cbx_status.SelectedItem = _status;  
        }

        private void SetupStatusComboBox()
        {
            cbx_status.Items.Clear();
            cbx_status.Items.Add("Enroll");
            cbx_status.Items.Add("Active");
            cbx_status.Items.Add("Graduated");
            cbx_status.Items.Add("Banned");
        }

        private void SetupGenderComboBox()
        {
            cbx_gender.Items.Clear();
            cbx_gender.Items.Add("Male");
            cbx_gender.Items.Add("Female");
        }

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            Thread.Sleep(1000);
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
                return value <= 4.0;
            }

            return false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ageKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tbAge.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool isNumberOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveClicked();
            
        }

        private void saveClicked()
        {
            if (string.IsNullOrEmpty(tbFName.Text) ||
                string.IsNullOrEmpty(tbLName.Text) ||
                string.IsNullOrEmpty(tbGPA.Text) ||
                string.IsNullOrEmpty(tbPhoneNumber.Text) ||
                string.IsNullOrEmpty(tbAge.Text))
            {
                MessageBox.Show("Please do not leave any fields empty", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(tbPhoneNumber.Text, @"^[0-9\-]+$") || !isNumberOnly(tbAge.Text))
            {
                MessageBox.Show("Non-numberic in Phone/Age field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                uC_studentManageList.instance._instanceFName = tbFName.Text;
                uC_studentManageList.instance._instanceLName = tbLName.Text;
                uC_studentManageList.instance._instancePhone = tbPhoneNumber.Text;
                uC_studentManageList.instance._instanceAge = int.Parse(tbAge.Text);
                uC_studentManageList.instance._instanceGPA = double.Parse(tbGPA.Text);
                uC_studentManageList.instance._instanceGender = cbx_gender.SelectedItem.ToString();
                uC_studentManageList.instance._instanceStatus = cbx_status.SelectedItem.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
