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
    public partial class uC_userProfile : UserControl
    {
        public uC_userProfile()
        {
            InitializeComponent();
            startWhenFormOn();
        }


        //these functions/tasks will run when the form is started
        private void startWhenFormOn()
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
        }

    }
}
