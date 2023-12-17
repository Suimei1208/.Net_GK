using _521H0049_521H0174.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
//using System.Windows.Input;

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
        private readonly myDAL myDal = new myDAL();
        


        //main
        public frmMainController()
        {
            InitializeComponent();
            startWhenFormOn();
        }


        //these functions/tasks will run when the form is started
        private void startWhenFormOn()
        {
            dataControlMenuFlowContainer.Visible= false;
            userMenuFlowContainer.Visible = false;

            if (SharedData.Instance.Role.Equals("Admin"))
            {
                userMenuFlowContainer.Visible= true;
            }
            if (SharedData.Instance.Role.Equals("Admin")|| SharedData.Instance.Role.Equals("Manager"))
            {
                dataControlMenuFlowContainer.Visible = true;
            }
        }


        //exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //Button user information
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            clearUserControls();
            uC_userProfile uc = new uC_userProfile();
            uc.Dock= DockStyle.Fill;
            Main.Controls.Add(uc);
            //uc.Show();
        }

        //Button log out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SharedData.Instance.ClearUser();
            

            Application.Restart();
            this.Close();
        }


        //Clear user control in main container
        private void clearUserControls()
        {
            if (Main.Controls.Count > 0) 
            { 
                Main.Controls.Clear();
            }
        }


        //Buttons of Student Container
        private void btnStudentList_Click(object sender, EventArgs e)
        {
            clearUserControls();
            uC_studentManageList uc = new uC_studentManageList();
            uc.Dock = DockStyle.Fill;
            Main.Controls.Add(uc);
        }
        // -
        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            clearUserControls();
            uC_CertificateList uc = new uC_CertificateList();
            uc.Dock = DockStyle.Fill;
            Main.Controls.Add(uc);
        }


        //Buttons of User Container
        private void btnUsersList_Click(object sender, EventArgs e)
        {
            clearUserControls();
            uC_userManagement uc = new uC_userManagement();
            uc.Dock = DockStyle.Fill;
            Main.Controls.Add(uc);
        }
        // -
        private void btnUserLoginHistory_Click(object sender, EventArgs e)
        {
            clearUserControls();
            uC_userLoginHistory uc = new uC_userLoginHistory();
            uc.Dock = DockStyle.Fill;
            Main.Controls.Add(uc);
        }


        //Buttons of Data Container
        private void btnImport_Click(object sender, EventArgs e)
        {
            clearUserControls();
            Import import = new Import();
            import.Dock = DockStyle.Fill;
            Main.Controls.Add(import);
            
        }
        // -
        private void btnExport_Click(object sender, EventArgs e)
        {           
            clearUserControls();
            Export export = new Export();
            export.Dock = DockStyle.Fill;
            Main.Controls.Add(export);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
