namespace _521H0049_521H0174
{
    partial class frmMainController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.FormFLContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.userMenuFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUserMenuMain = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Panel();
            this.btnUsersList = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnUserLoginHistory = new System.Windows.Forms.Button();
            this.studentMenuFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStudentManageMain = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnStudentList = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnStudentDetails = new System.Windows.Forms.Button();
            this.dataControlMenuFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDataControl = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Panel();
            this.Slider = new System.Windows.Forms.Timer(this.components);
            this.userSlider = new System.Windows.Forms.Timer(this.components);
            this.studentSlider = new System.Windows.Forms.Timer(this.components);
            this.dataSlider = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.FormFLContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.userMenuFlowContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.btnUserList.SuspendLayout();
            this.panel8.SuspendLayout();
            this.studentMenuFlowContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.dataControlMenuFlowContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpenMenu);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MD);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MM);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MU);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "| SMS";
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.BackgroundImage = global::_521H0049_521H0174.Properties.Resources.menu_icon;
            this.btnOpenMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenMenu.FlatAppearance.BorderSize = 0;
            this.btnOpenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMenu.Location = new System.Drawing.Point(6, 5);
            this.btnOpenMenu.Margin = new System.Windows.Forms.Padding(10);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(40, 40);
            this.btnOpenMenu.TabIndex = 2;
            this.btnOpenMenu.UseVisualStyleBackColor = true;
            this.btnOpenMenu.Click += new System.EventHandler(this.btnOpenMenu_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::_521H0049_521H0174.Properties.Resources.minimize_icon;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1183, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::_521H0049_521H0174.Properties.Resources.x_icon_black;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1235, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormFLContainer
            // 
            this.FormFLContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.FormFLContainer.Controls.Add(this.panel6);
            this.FormFLContainer.Controls.Add(this.userMenuFlowContainer);
            this.FormFLContainer.Controls.Add(this.studentMenuFlowContainer);
            this.FormFLContainer.Controls.Add(this.dataControlMenuFlowContainer);
            this.FormFLContainer.Controls.Add(this.panel5);
            this.FormFLContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.FormFLContainer.Location = new System.Drawing.Point(0, 50);
            this.FormFLContainer.MaximumSize = new System.Drawing.Size(200, 670);
            this.FormFLContainer.MinimumSize = new System.Drawing.Size(70, 670);
            this.FormFLContainer.Name = "FormFLContainer";
            this.FormFLContainer.Size = new System.Drawing.Size(200, 670);
            this.FormFLContainer.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnUserInfo);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 80);
            this.panel6.TabIndex = 5;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUserInfo.FlatAppearance.BorderSize = 2;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnUserInfo.Image = global::_521H0049_521H0174.Properties.Resources.icon_user_untoggle;
            this.btnUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 0);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(195, 80);
            this.btnUserInfo.TabIndex = 4;
            this.btnUserInfo.Text = "      User";
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // userMenuFlowContainer
            // 
            this.userMenuFlowContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userMenuFlowContainer.Controls.Add(this.panel3);
            this.userMenuFlowContainer.Controls.Add(this.btnUserList);
            this.userMenuFlowContainer.Controls.Add(this.panel8);
            this.userMenuFlowContainer.Location = new System.Drawing.Point(0, 86);
            this.userMenuFlowContainer.Margin = new System.Windows.Forms.Padding(0);
            this.userMenuFlowContainer.MaximumSize = new System.Drawing.Size(195, 180);
            this.userMenuFlowContainer.MinimumSize = new System.Drawing.Size(80, 80);
            this.userMenuFlowContainer.Name = "userMenuFlowContainer";
            this.userMenuFlowContainer.Size = new System.Drawing.Size(195, 80);
            this.userMenuFlowContainer.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUserMenuMain);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 80);
            this.panel3.TabIndex = 0;
            // 
            // btnUserMenuMain
            // 
            this.btnUserMenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUserMenuMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUserMenuMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserMenuMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserMenuMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUserMenuMain.FlatAppearance.BorderSize = 2;
            this.btnUserMenuMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMenuMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMenuMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnUserMenuMain.Image = global::_521H0049_521H0174.Properties.Resources.icon_home_untoggle;
            this.btnUserMenuMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMenuMain.Location = new System.Drawing.Point(0, 0);
            this.btnUserMenuMain.Name = "btnUserMenuMain";
            this.btnUserMenuMain.Size = new System.Drawing.Size(195, 80);
            this.btnUserMenuMain.TabIndex = 1;
            this.btnUserMenuMain.Text = "           Users menu";
            this.btnUserMenuMain.UseVisualStyleBackColor = false;
            this.btnUserMenuMain.Click += new System.EventHandler(this.btnUserMenuMain_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Controls.Add(this.btnUsersList);
            this.btnUserList.Location = new System.Drawing.Point(3, 89);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(195, 40);
            this.btnUserList.TabIndex = 6;
            // 
            // btnUsersList
            // 
            this.btnUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUsersList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsersList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUsersList.FlatAppearance.BorderSize = 2;
            this.btnUsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersList.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnUsersList.Image = global::_521H0049_521H0174.Properties.Resources.icon_child_list_untoggle;
            this.btnUsersList.Location = new System.Drawing.Point(0, 0);
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.Size = new System.Drawing.Size(195, 40);
            this.btnUsersList.TabIndex = 4;
            this.btnUsersList.Text = "List        ";
            this.btnUsersList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsersList.UseVisualStyleBackColor = false;
            this.btnUsersList.Click += new System.EventHandler(this.btnUsersList_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnUserLoginHistory);
            this.panel8.Location = new System.Drawing.Point(3, 135);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(195, 40);
            this.panel8.TabIndex = 6;
            // 
            // btnUserLoginHistory
            // 
            this.btnUserLoginHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUserLoginHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserLoginHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserLoginHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserLoginHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnUserLoginHistory.FlatAppearance.BorderSize = 2;
            this.btnUserLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLoginHistory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLoginHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnUserLoginHistory.Image = global::_521H0049_521H0174.Properties.Resources.icon_child_history_untoggle;
            this.btnUserLoginHistory.Location = new System.Drawing.Point(0, 0);
            this.btnUserLoginHistory.Name = "btnUserLoginHistory";
            this.btnUserLoginHistory.Size = new System.Drawing.Size(195, 40);
            this.btnUserLoginHistory.TabIndex = 4;
            this.btnUserLoginHistory.Text = "History     ";
            this.btnUserLoginHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserLoginHistory.UseVisualStyleBackColor = false;
            this.btnUserLoginHistory.Click += new System.EventHandler(this.btnUserLoginHistory_Click);
            // 
            // studentMenuFlowContainer
            // 
            this.studentMenuFlowContainer.Controls.Add(this.panel2);
            this.studentMenuFlowContainer.Controls.Add(this.panel7);
            this.studentMenuFlowContainer.Controls.Add(this.panel9);
            this.studentMenuFlowContainer.Location = new System.Drawing.Point(3, 169);
            this.studentMenuFlowContainer.MaximumSize = new System.Drawing.Size(195, 180);
            this.studentMenuFlowContainer.MinimumSize = new System.Drawing.Size(80, 80);
            this.studentMenuFlowContainer.Name = "studentMenuFlowContainer";
            this.studentMenuFlowContainer.Size = new System.Drawing.Size(195, 180);
            this.studentMenuFlowContainer.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStudentManageMain);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 80);
            this.panel2.TabIndex = 2;
            // 
            // btnStudentManageMain
            // 
            this.btnStudentManageMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnStudentManageMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudentManageMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentManageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudentManageMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnStudentManageMain.FlatAppearance.BorderSize = 2;
            this.btnStudentManageMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentManageMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentManageMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnStudentManageMain.Image = global::_521H0049_521H0174.Properties.Resources.icon_manage_untoggle;
            this.btnStudentManageMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentManageMain.Location = new System.Drawing.Point(0, 0);
            this.btnStudentManageMain.Name = "btnStudentManageMain";
            this.btnStudentManageMain.Size = new System.Drawing.Size(195, 80);
            this.btnStudentManageMain.TabIndex = 1;
            this.btnStudentManageMain.Text = "              Student                 Management";
            this.btnStudentManageMain.UseVisualStyleBackColor = false;
            this.btnStudentManageMain.Click += new System.EventHandler(this.btnStudentManageMain_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnStudentList);
            this.panel7.Location = new System.Drawing.Point(3, 89);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 40);
            this.panel7.TabIndex = 3;
            // 
            // btnStudentList
            // 
            this.btnStudentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnStudentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudentList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnStudentList.FlatAppearance.BorderSize = 2;
            this.btnStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnStudentList.Image = global::_521H0049_521H0174.Properties.Resources.icon_child_list_untoggle;
            this.btnStudentList.Location = new System.Drawing.Point(0, 0);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(195, 40);
            this.btnStudentList.TabIndex = 1;
            this.btnStudentList.Text = "List       ";
            this.btnStudentList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentList.UseVisualStyleBackColor = false;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnStudentDetails);
            this.panel9.Location = new System.Drawing.Point(3, 135);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(195, 40);
            this.panel9.TabIndex = 3;
            // 
            // btnStudentDetails
            // 
            this.btnStudentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnStudentDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudentDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudentDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnStudentDetails.FlatAppearance.BorderSize = 2;
            this.btnStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnStudentDetails.Image = global::_521H0049_521H0174.Properties.Resources.icon_child_detail_untoggle;
            this.btnStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.btnStudentDetails.Name = "btnStudentDetails";
            this.btnStudentDetails.Size = new System.Drawing.Size(195, 40);
            this.btnStudentDetails.TabIndex = 1;
            this.btnStudentDetails.Text = "Certificates";
            this.btnStudentDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentDetails.UseVisualStyleBackColor = false;
            this.btnStudentDetails.Click += new System.EventHandler(this.btnStudentDetails_Click);
            // 
            // dataControlMenuFlowContainer
            // 
            this.dataControlMenuFlowContainer.Controls.Add(this.panel4);
            this.dataControlMenuFlowContainer.Controls.Add(this.panel10);
            this.dataControlMenuFlowContainer.Controls.Add(this.panel11);
            this.dataControlMenuFlowContainer.Location = new System.Drawing.Point(3, 355);
            this.dataControlMenuFlowContainer.MaximumSize = new System.Drawing.Size(195, 180);
            this.dataControlMenuFlowContainer.MinimumSize = new System.Drawing.Size(80, 80);
            this.dataControlMenuFlowContainer.Name = "dataControlMenuFlowContainer";
            this.dataControlMenuFlowContainer.Size = new System.Drawing.Size(195, 80);
            this.dataControlMenuFlowContainer.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDataControl);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 80);
            this.panel4.TabIndex = 2;
            // 
            // btnDataControl
            // 
            this.btnDataControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnDataControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDataControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDataControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnDataControl.FlatAppearance.BorderSize = 2;
            this.btnDataControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnDataControl.Image = global::_521H0049_521H0174.Properties.Resources.icon_database_untoggle;
            this.btnDataControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataControl.Location = new System.Drawing.Point(0, 0);
            this.btnDataControl.Name = "btnDataControl";
            this.btnDataControl.Size = new System.Drawing.Size(195, 80);
            this.btnDataControl.TabIndex = 1;
            this.btnDataControl.Text = "             Data Control";
            this.btnDataControl.UseVisualStyleBackColor = false;
            this.btnDataControl.Click += new System.EventHandler(this.btnDataControl_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnImport);
            this.panel10.Location = new System.Drawing.Point(3, 89);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(195, 40);
            this.panel10.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnImport.Image = global::_521H0049_521H0174.Properties.Resources.icon_child_import_file_untoggle;
            this.btnImport.Location = new System.Drawing.Point(0, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(195, 40);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnExport);
            this.panel11.Location = new System.Drawing.Point(3, 135);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(195, 40);
            this.panel11.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnExport.FlatAppearance.BorderSize = 2;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnExport.Image = global::_521H0049_521H0174.Properties.Resources.icon_child_export_xls_untoggle;
            this.btnExport.Location = new System.Drawing.Point(0, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(195, 40);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLogOut);
            this.panel5.Location = new System.Drawing.Point(3, 441);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 80);
            this.panel5.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.btnLogOut.Image = global::_521H0049_521H0174.Properties.Resources.icon_logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(195, 80);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "       Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(184)))), ((int)(((byte)(151)))));
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(200, 50);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1080, 670);
            this.Main.TabIndex = 2;
            // 
            // Slider
            // 
            this.Slider.Interval = 1;
            this.Slider.Tick += new System.EventHandler(this.slide);
            // 
            // userSlider
            // 
            this.userSlider.Interval = 1;
            this.userSlider.Tick += new System.EventHandler(this.userSlide);
            // 
            // studentSlider
            // 
            this.studentSlider.Interval = 1;
            this.studentSlider.Tick += new System.EventHandler(this.studentSlide);
            // 
            // dataSlider
            // 
            this.dataSlider.Interval = 1;
            this.dataSlider.Tick += new System.EventHandler(this.dataSlide);
            // 
            // frmMainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.Main);
            this.Controls.Add(this.FormFLContainer);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMainController";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainController";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FormFLContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.userMenuFlowContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.btnUserList.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.studentMenuFlowContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.dataControlMenuFlowContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel FormFLContainer;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserMenuMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDataControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStudentManageMain;
        private System.Windows.Forms.Timer Slider;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnUserLoginHistory;
        private System.Windows.Forms.Panel btnUserList;
        private System.Windows.Forms.Button btnUsersList;
        private System.Windows.Forms.FlowLayoutPanel userMenuFlowContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnStudentDetails;
        private System.Windows.Forms.FlowLayoutPanel studentMenuFlowContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnStudentList;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.FlowLayoutPanel dataControlMenuFlowContainer;
        private System.Windows.Forms.Timer userSlider;
        private System.Windows.Forms.Timer studentSlider;
        private System.Windows.Forms.Timer dataSlider;
    }
}