﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    public partial class uC_userProfile : UserControl
    {
        private myDAL myDAL;
        
        private int flowWidth;
        public uC_userProfile()
        {
            InitializeComponent();
            
            startWhenFormOn();
        }


        //these functions/tasks will run when the form is started
        private void startWhenFormOn()
        {
            myDAL = new myDAL();
            string username = SharedData.Instance.Username;
            string fileName;
            if (myDAL.GetAvatarPath(username) == null)
            {
                fileName = "normal.png";
            }
            else
            {
                fileName = myDAL.GetAvatarPath(username);
            }
            rjCircularPictureBox1.ImageLocation = Path.Combine("../../Avatar/", fileName);

            flowWidth = this.Width;

            label1.Text = username;

            int x = (flowWidth - label1.Width) / 2;
            int y = 260;
            label1.Location = new System.Drawing.Point(x, y);

            label2.Text = myDAL.GetRole(username);
            x = (flowWidth - label2.Width) / 2;
            y = 295;
            label2.Location = new System.Drawing.Point(x, y);


            x = (flowWidth - rjCircularPictureBox1.Width) / 2;
            y = 25;
            rjCircularPictureBox1.Location = new System.Drawing.Point(x, y);


            x = (flowWidth - rjCircularPictureBox2.Width + 150) / 2;
            y = 195;
            rjCircularPictureBox2.Location = new System.Drawing.Point(x, y);
        }

        /*
        //function below make square img -> round img
        private void roundImg(PictureBox px, int pxWidth, int pxHeight)
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, pxWidth, pxHeight);
            Region r = new Region(obj);
            px.Region = r;
        }


        //function below make square panel -> round panel
        private void roundPanel(Panel p, int pWidth, int pHeight)
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, pWidth, pHeight);
            Region r = new Region(obj);
            p.Region = r;
        }*/

        private void uC_userProfile_Load(object sender, EventArgs e)
        {
            //startWhenFormOn();
        }
        
        private void rjCircularPictureBox2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico;*.tiff;*.tif";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string username = SharedData.Instance.Username;
                    string relativeFolderPath = "../../Avatar/";
                    string destinationPath = Path.Combine(Application.StartupPath, relativeFolderPath);

                    Directory.CreateDirectory(destinationPath);
                    MessageBox.Show(username);

                    /*
                   try
                   {*/
                        if (myDAL.GetAvatarPath(username) != null)
                        {
                            string existingAvatarPath = Path.Combine("../../Avatar/", myDAL.GetAvatarPath(username));
                            if (!string.IsNullOrEmpty(existingAvatarPath))
                            {
                                File.Delete(existingAvatarPath);
                            }
                        }
                        

                        string destinationFileName = Path.GetFileName(openFileDialog.FileName);
                        MessageBox.Show(destinationFileName);
                        string destinationFilePath = Path.Combine(destinationPath, Path.GetFileName(openFileDialog.FileName));
                        File.Copy(openFileDialog.FileName, destinationFilePath);

                        myDAL.updateAvatar(username, destinationFileName);
                        MessageBox.Show("Lưu ảnh thành công!");
                        rjCircularPictureBox1.ImageLocation = openFileDialog.FileName;
                    /*}
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                    }*/
                }
            }
        }

        private void formSizeChanged(object sender, EventArgs e)
        {
            //startWhenFormOn();
        }
    }
}
