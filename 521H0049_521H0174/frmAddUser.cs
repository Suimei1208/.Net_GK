using _521H0049_521H0174.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _521H0049_521H0174
{
    public partial class frmAddUser : Form
    {
        private readonly myDAL myDal = new myDAL();
        public frmAddUser()
        {
            InitializeComponent();
            fillRoleInCbx();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text) || 
                string.IsNullOrEmpty(tb_age.Text) || 
                string.IsNullOrEmpty(tb_phoneNumber.Text)||
                string.IsNullOrEmpty(tbFullName.Text))
            {
                MessageBox.Show("Please do not leave any field empty","Empty Field",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(tb_phoneNumber.Text, @"^[0-9\-]+$") || !isNumberOnly(tb_age.Text))
            {
                MessageBox.Show("Non-numberic in Phone/Age field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = tb_username.Text;
                string fullname = tbFullName.Text;
                int age = int.Parse(tb_age.Text);
                string phoneNumber = tb_phoneNumber.Text;
                string role = cbx_Role.SelectedItem.ToString();
                int id = myDal.GetLatestUserId();
                string hashedPass = myDal.HashPassword(username);

                if (myDal.IsExisted(username,phoneNumber))
                {
                    MessageBox.Show("Username or Phone number is already been taken", "Data Existed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //UserID = id + 1,
                {
                        User newUser = new User
                        {
                            
                            Username = username,
                            FullName = fullname,
                            Password = hashedPass,
                            Age = age,
                            PhoneNumber = phoneNumber,
                            Role = role,
                            Avatar = "",
                            Status = "Normal"
                        };

                        myDal.AddUser(newUser);
                        DialogResult = DialogResult.OK;
                        Close();
                }    

                
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

        private void fillRoleInCbx()
        {
       
            List<string> roles = new List<string> { "Admin", "Manager", "Employee" };
            cbx_Role.Items.AddRange(roles.ToArray());
            cbx_Role.SelectedIndex = 0;
        }

        private void AgeFieldPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneFieldPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
