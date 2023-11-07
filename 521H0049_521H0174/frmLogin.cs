using _521H0049_521H0174.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    public partial class frmLogin : Form
    {
        private bool isHide = true;
        private myDAL myDAL = new myDAL();

        public frmLogin()
        {
            InitializeComponent();
            errlabel.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                btnSeePass.BackgroundImage = Properties.Resources.icon_closeEye;
                tbPassword.PasswordChar = '*';
                isHide = true;
            }
            else
            {
                btnSeePass.BackgroundImage = Properties.Resources.icon_openEye;
                tbPassword.PasswordChar = '\0';
                isHide = false;
            }


        }

        private void InputValidator()
        {
            

            if (tbUsername.Text.Equals("") || tbUsername.Text.Equals(""))
            {
                errlabel.Text = "Username/Password is empty";
                errlabel.Show();
            }
            
            else if(myDAL.UserExists(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show("Oke");
                frmMainController f = new frmMainController(true);
                this.DialogResult= DialogResult.OK;
                f.Show();
                this.Close();
            }
            else
            {
                errlabel.Text = "Incorrect Username/Password";
                errlabel.Show();
            }

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if (myDAL.UserExists(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show("Oke");
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Close();
            }*/
            InputValidator();

        }

        private void User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
                InputValidator();
        }

        private void Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                InputValidator();
        }
    }
}
