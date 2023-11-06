using DevExpress.Utils.Extensions;
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
    public partial class frmMainController : Form
    {
        //import parameter
        private bool isDragging = false;                    //draggable control bar 
        private Point offset;                               // -
        private bool isMainContainerExpand = true;          //main flow panel
        private bool isUserContainerExpand = false;         //child flow pannel
        private bool isStudentContainerExpand = false;      // -
        private bool isDataContainerExpand = false;         // -
        private bool isLogged = false;



        //main
        public frmMainController(bool isLogged)
        {
            InitializeComponent();
            startWhenFormOn(isLogged);
        }


        //these functions/tasks will run when the form is started
        private void startWhenFormOn(bool isLogged)
        {
            if (isLogged) // change this to !isLogged when database is done
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                if (login.DialogResult== DialogResult.OK) 
                { 
                    
                }
                else
                {
                    this.Close();
                }
            }
        }


        //exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //minimize application
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }


        //draggable control bar 
        private void topPanel_MD(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = e.Location;
            }
        }
        // -
        private void topPanel_MM(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }
        // -
        private void topPanel_MU(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }


        //main container slide
        private void slide(object sender, EventArgs e)
        {
            if (isMainContainerExpand) 
            {
                FormFLContainer.Width -= 10;
                if (FormFLContainer.Width == 70)
                {
                    isMainContainerExpand = false;
                    Slider.Stop();
                }
            }else{
                FormFLContainer.Width += 10;
                if (FormFLContainer.Width == 200)
                {
                    isMainContainerExpand = true;
                    Slider.Stop();
                }
            }
        }


        //click menu button to hide/show container
        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            Slider.Start();
            checkIfAnyChildOpen();
        }


        //user child container slide
        private void userSlide(object sender, EventArgs e)
        {
            if (isUserContainerExpand)
            {
                userMenuFlowContainer.Height -= 10;
                if (userMenuFlowContainer.Height == 80)
                {
                    isUserContainerExpand = false;
                    userSlider.Stop();
                }
            }
            else
            {
                userMenuFlowContainer.Height += 10;
                if (userMenuFlowContainer.Height == 180)
                {
                    isUserContainerExpand = true;
                    userSlider.Stop();
                }
            }
        }


        //student child container slide
        private void studentSlide(object sender, EventArgs e)
        {
            if (isStudentContainerExpand)
            {
                studentMenuFlowContainer.Height -= 10;
                if (studentMenuFlowContainer.Height == 80)
                {
                    isStudentContainerExpand = false;
                    studentSlider.Stop();
                }
            }
            else
            {
                studentMenuFlowContainer.Height += 10;
                if (studentMenuFlowContainer.Height == 180)
                {
                    isStudentContainerExpand = true;
                    studentSlider.Stop();
                }
            }
        }


        //data child container slide
        private void dataSlide(object sender, EventArgs e)
        {
            if (isDataContainerExpand)
            {
                dataControlMenuFlowContainer.Height -= 10;
                if (dataControlMenuFlowContainer.Height == 80)
                {
                    isDataContainerExpand = false;
                    dataSlider.Stop();
                }
            }
            else
            {
                dataControlMenuFlowContainer.Height += 10;
                if (dataControlMenuFlowContainer.Height == 180)
                {
                    isDataContainerExpand = true;
                    dataSlider.Stop();
                }
            }
        }


        //check if any menu is open
        private void checkIfAnyChildOpen()
        {
            if (isUserContainerExpand)
            {
                userSlider.Start();
            }
            if (isStudentContainerExpand)
            {
                studentSlider.Start();
            }
            if (isDataContainerExpand)
            {
                dataSlider.Start();
            }
        }


        //click menu button to hide/show child container
        private void btnUserMenuMain_Click(object sender, EventArgs e)
        {
            if (isMainContainerExpand)
            {
                checkIfAnyChildOpen();
                userSlider.Start();
            }
            else
            {
                Slider.Start();
                checkIfAnyChildOpen();
                userSlider.Start();
            }
        }
        // -
        private void btnStudentManageMain_Click(object sender, EventArgs e)
        {
            if (isMainContainerExpand)
            {
                checkIfAnyChildOpen();
                studentSlider.Start();
            }
            else
            {
                Slider.Start();
                checkIfAnyChildOpen();
                userSlider.Start();
            }
        }
        // -
        private void btnDataControl_Click(object sender, EventArgs e)
        {
            if (isMainContainerExpand)
            {
                checkIfAnyChildOpen();
                dataSlider.Start();
            }
            else
            {
                Slider.Start();
                checkIfAnyChildOpen();
                userSlider.Start();
            }
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            uC_userProfile uc = new uC_userProfile();
            Main.AddControl(uc);
            uc.Dock= DockStyle.Fill;
        }
    }
}
