using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _521H0049_521H0174
{
    public partial class uC_userProfile : UserControl
    {
        private myDAL myDAL;
        private string selectedImagePath;
        public uC_userProfile()
        {
            InitializeComponent();
            myDAL = new myDAL();
            string username = SharedData.Instance.username;
            string fileName;
            if(myDAL.GetAvatarPath(username) == null)
            {
                fileName = "normal.png";
            }
            else
            {
                fileName = myDAL.GetAvatarPath(username);
            }
            rjCircularPictureBox1.ImageLocation = Path.Combine("../../Avatar/", fileName);
            label1.Text = username;
            label2.Text = myDAL.GetRole(username);
            //startWhenFormOn();
        }


        //these functions/tasks will run when the form is started
        /*private void startWhenFormOn()
        {
            roundImg(userImage, userImage.Width, userImage.Height);
            roundPanel(userInfoPanel, 2, 2);
        }


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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void uC_userProfile_Load(object sender, EventArgs e)
        {

        }
        
        private void rjCircularPictureBox2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico;*.tiff;*.tif";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string username = SharedData.Instance.username;
                    string relativeFolderPath = "../../Avatar/";
                    string destinationPath = Path.Combine(Application.StartupPath, relativeFolderPath);

                    Directory.CreateDirectory(destinationPath);
                    MessageBox.Show(username);

                     /*
                    try
                    {*/
                        string existingAvatarPath = Path.Combine("../../Avatar/", myDAL.GetAvatarPath(username));
                        if (!string.IsNullOrEmpty(existingAvatarPath))
                        {
                            File.Delete(existingAvatarPath);
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
    }
}
