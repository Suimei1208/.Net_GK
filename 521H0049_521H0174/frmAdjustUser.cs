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
    public partial class frmAdjustUser : Form
    {
        public string _Username;
        public string _Fullname;
        public string _Phone;
        public int _Age;
        public string _Status;
        public static frmAdjustUser instance;


        public frmAdjustUser()
        {
            InitializeComponent();
            instance=this;
        }

        public frmAdjustUser(string username, string fullname, string phone, int age, string status)
        {
            InitializeComponent();
            syncData(username, fullname, phone, age, status);     
            setDataToTextBox();
        }

        private void syncData(string username, string fullname, string phone, int age, string status) 
        { 
            this._Username= username;
            this._Fullname= fullname;
            this._Phone= phone;
            this._Age= age;
            this._Status= status;
        }

        private void setDataToTextBox()
        {
            tb_username.Text = _Username;
            tb_phoneNumber.Text = _Phone;
            tb_age.Text = _Age.ToString();
            tb_fullname.Text = _Fullname;


            if (_Status.Equals("Normal"))
            {
                btn_status.BackColor = Color.Red;
                btn_status.ForeColor = Color.White;
                btn_status.Text = "Lock user";
            }
            else
            {
                btn_status.BackColor = Color.LimeGreen;
                btn_status.ForeColor = Color.White;
                btn_status.Text = "Unlock user";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            if (_Status.Equals("Normal"))
            { 
                btn_status.BackColor = Color.LimeGreen;
                btn_status.ForeColor = Color.White;
                btn_status.Text = "Unlock user";
                btn_status.TextAlign = ContentAlignment.MiddleCenter;
                _Status = "Locked";
            }
            else
            {
                btn_status.BackColor = Color.Red;
                btn_status.ForeColor = Color.White;
                btn_status.Text = "Lock user"; 
                btn_status.TextAlign = ContentAlignment.MiddleCenter;
                _Status = "Normal";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            adjustData();
        }

        private void adjustData()
        {
            if (tb_username.Text.Length == 0 || tb_phoneNumber.Text.Length == 0 || tb_age.Text.Length == 0 || tb_fullname.Text.Length ==0)
            {
                MessageBox.Show("Input field is empty", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(tb_phoneNumber.Text, @"^[0-9\-]+$") || !isNumberOnly(tb_age.Text))
            {
                MessageBox.Show("Non-numberic in Phone/Age field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                uC_userManagement.instance._instanceUsername = tb_username.Text;
                uC_userManagement.instance._instanceFullName = tb_fullname.Text;
                uC_userManagement.instance._instancePhone = tb_phoneNumber.Text;
                uC_userManagement.instance._instanceAge = int.Parse(tb_age.Text);
                uC_userManagement.instance._instanceStatus = _Status;
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

        private void keypressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
