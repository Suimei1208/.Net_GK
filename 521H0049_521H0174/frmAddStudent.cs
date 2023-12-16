using _521H0049_521H0174.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _521H0049_521H0174
{
    public partial class frmAddStudent : Form
    {
        private readonly myDAL myDal = new myDAL();
        public frmAddStudent()
        {
            InitializeComponent();
            onStartForm();
        }

        private void onStartForm()
        {
            SetupGenderComboBox();
            SetupStatusComboBox();
        }

        private void SetupGenderComboBox()
        {
            cbx_gender.Items.Clear();
            cbx_gender.Items.Add("Male");
            cbx_gender.Items.Add("Female");

            cbx_gender.SelectedIndex = 0;
        }

        private void SetupStatusComboBox()
        {
            cbx_status.Items.Clear();

            cbx_status.Items.Add("Enroll");
            cbx_status.Items.Add("Active");
            cbx_status.Items.Add("Graduated");
            cbx_status.Items.Add("Banned");

            cbx_status.SelectedIndex = 0;
        }

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',') || (e.KeyChar == ',' && ((TextBox)sender).Text.Contains('.')))
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



        private void AgekeyPressed(object sender, KeyPressEventArgs e)
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFName.Text)||
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
                Student newStd = new Student {
                    FirstName = tbFName.Text,
                    LastName = tbLName.Text,
                    Age = int.Parse(tbAge.Text),
                    Gender = cbx_gender.SelectedItem.ToString(),
                    GPA = double.Parse(tbGPA.Text),
                    Status = cbx_status.SelectedItem.ToString(),
                    PhoneNumber = tbPhoneNumber.Text
                };

                myDal.AddStudent(newStd);
                DialogResult = DialogResult.OK;
                Close();
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
