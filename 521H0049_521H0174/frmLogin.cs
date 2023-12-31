﻿using _521H0049_521H0174.Models;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace _521H0049_521H0174
{
    public partial class frmLogin : Form
    {
        //import parameter
        private bool isDragging = false;                    //draggable control bar 
        private Point offset;                               // -
        private bool isHide = true;                         //Reveal/Hide password
        private readonly myDAL myDal = new myDAL();


        public frmLogin()
        {
            InitializeComponent();
            startWhenFormOn();
        }


        //these functions/tasks will run when the form is started
        private void startWhenFormOn()
        {
            errlabel.Hide();
            loadingIcon.Hide();
        }


        //exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Abort;
            this.Close();
        }


        //Reveal Hidden text in password field
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

        //This function make sure if user is existed in database or not
        private async void InputValidator()
        {
            loadingIcon.Show();
            loadingIcon.Refresh();

            

            if (tbUsername.Text.Equals("") || tbUsername.Text.Equals(""))
            {
                //MessageBox.Show("Load icon run");
                loadingIcon.Hide();
                errlabel.Text = "Username/Password is empty";
                errlabel.Show();
            }
            
            else if(await myDal.UserExists(tbUsername.Text, tbPassword.Text))
            {
                
                    
                    loadingIcon.Hide();
                    myDal.LogUserLogin(tbUsername.Text);
                    this.Hide();
                    Form f;
                    if (myDal.GetUserStatusByUsername(tbUsername.Text).Equals("Normal"))
                    {
                        myDal.LogUserLogin(tbUsername.Text);
                        NavigateToMainForm();
                    }
                    else
                    {
                        loadingIcon.Hide();
                        errlabel.Text = "This user has been blocked";
                        errlabel.Show();
                    }
                
            }
            else
            {
                //MessageBox.Show("Load icon run");
                loadingIcon.Hide();
                errlabel.Text = "Incorrect Username/Password";
                errlabel.Show();
            }
            
        }

        private void NavigateToMainForm()
        {
            loadingIcon.Hide();
            this.Hide();

            using (Form mainForm = new frmMainController())
            {
                mainForm.ShowDialog();
            }

            this.Close();
        }

        //When click on login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            InputValidator();

        }

        //Increase user experience by detecting enter key press -> run login button function
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

        //Declare function to make a form draggable
        //when hold mouse
        private void MD(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = e.Location;
            }
        }
        //when move mouse
        private void MM(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }
        //when release mouse
        private void MU(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }


        //make form Draggable
        private void rPanel_MD(object sender, MouseEventArgs e)
        {
            MD(sender, e);
        }
        // -
        private void rPanel_MM(object sender, MouseEventArgs e)
        {
            MM(sender, e);
        }
        // -
        private void rPanel_MU(object sender, MouseEventArgs e)
        {
            MU(sender, e);
        }
        // -
        private void lPanel_MD(object sender, MouseEventArgs e)
        {
            MD(sender, e);
        }
        // -
        private void lPanel_MM(object sender, MouseEventArgs e)
        {
            MM(sender, e);
        }
        // -
        private void lPanel_MU(object sender, MouseEventArgs e)
        {
            MU(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
