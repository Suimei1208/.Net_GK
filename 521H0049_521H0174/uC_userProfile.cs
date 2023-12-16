using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    public partial class uC_userProfile : UserControl
    {
        private readonly myDAL myDal = new myDAL();
        public static uC_userProfile instance;
        public static string _instanceUsername;
        public static int _instanceAge;
        public static string _instanceFullname;
        public static string _instancePhone;

        private int flowWidth;
        public uC_userProfile()
        {
            InitializeComponent();
            instance= this;
            startWhenFormOn();
        }

        private void updateData()
        {
            var user = myDal.FindUserById(SharedData.Instance.Id);
            label1.Text = user.FullName.ToString();
            labelUsername.Text = user.Username.ToString();
            LabelAge.Text = user.Age.ToString();
            LabelStatus.Text = user.Status.ToString();
            LabelPhone.Text = user.PhoneNumber.ToString();
        }


        //these functions/tasks will run when the form is started
        private void startWhenFormOn()
        {
            string username = SharedData.Instance.Username;
            string fileName;
            if (myDal.GetAvatarPath(username) == null)
            {
                fileName = "normal.png";
            }
            else
            {
                fileName = myDal.GetAvatarPath(username);
            }
            rjCircularPictureBox1.ImageLocation = Path.Combine("../../Avatar/", fileName);

            flowWidth = this.Width;

            updateData();

            int x = (flowWidth - label1.Width) / 2;
            int y = 260;
            label1.Location = new System.Drawing.Point(x, y);

            label2.Text = myDal.GetRole(username);
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
                        if (myDal.GetAvatarPath(username) != null)
                        {
                            string existingAvatarPath = Path.Combine("../../Avatar/", myDal.GetAvatarPath(username));
                            if (!string.IsNullOrEmpty(existingAvatarPath))
                            {
                                File.Delete(existingAvatarPath);
                            }
                        }
                        

                        string destinationFileName = Path.GetFileName(openFileDialog.FileName);
                        MessageBox.Show(destinationFileName);
                        string destinationFilePath = Path.Combine(destinationPath, Path.GetFileName(openFileDialog.FileName));
                        File.Copy(openFileDialog.FileName, destinationFilePath);

                        myDal.updateAvatar(username, destinationFileName);
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmUserDataAdjustment f = new frmUserDataAdjustment();
            if (f.ShowDialog() == DialogResult.OK)
            {
                label1.Text = _instanceFullname;
                labelUsername.Text = _instanceUsername;
                LabelAge.Text = _instanceAge.ToString();
                LabelPhone.Text = _instancePhone;
            }
            
        }

        private void btn_adjust_Click(object sender, EventArgs e)
        {
            frmChangePass f = new frmChangePass();
            if(f.ShowDialog() == DialogResult.OK)
            {
                label1.Text = _instanceFullname;
                labelUsername.Text = _instanceUsername;
                LabelAge.Text = _instanceAge.ToString();
                LabelPhone.Text = _instancePhone;
            }
            
        }
    }
}
