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
    public partial class frmUserDataAdjustment : Form
    {
        private readonly myDAL myDal = new myDAL();
        public static frmUserDataAdjustment instance;
        public frmUserDataAdjustment()
        {
            InitializeComponent();
            instance= this;
            whenFormOn();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void whenFormOn()
        {
            var user = myDal.FindUserById(SharedData.Instance.Id);
            tb_age.Text=user.Age.ToString();
            tb_fullname.Text=user.FullName.ToString();
            tb_phoneNumber.Text=user.PhoneNumber.ToString();
            tb_username.Text=user.Username.ToString();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_username.Text.Length == 0 || tb_phoneNumber.Text.Length == 0 || tb_age.Text.Length == 0 || tb_fullname.Text.Length == 0)
            {
                MessageBox.Show("Input field is empty", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(tb_phoneNumber.Text, @"^[0-9\-]+$") || !isNumberOnly(tb_age.Text))
            {
                MessageBox.Show("Non-numberic in Phone/Age field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User updatedUser = new User
                {
                    UserID = SharedData.Instance.Id,
                    Username = tb_username.Text,
                    FullName = tb_fullname.Text,
                    PhoneNumber = tb_phoneNumber.Text,
                    Age = int.Parse(tb_age.Text)
                };

                uC_userProfile._instanceUsername= updatedUser.Username;
                uC_userProfile._instanceAge = int.Parse(updatedUser.Age.ToString());
                uC_userProfile._instancePhone = updatedUser.PhoneNumber;
                uC_userProfile._instanceFullname = updatedUser.FullName;

                await myDal.UpdateUser(updatedUser);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
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

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
