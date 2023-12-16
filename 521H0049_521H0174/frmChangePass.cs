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
    public partial class frmChangePass : Form
    {
        private readonly myDAL myDal = new myDAL();
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOld.Text) || string.IsNullOrEmpty(tbNew.Text)|| string.IsNullOrEmpty(tbReNew.Text)) 
            {
                MessageBox.Show("Input field is empty", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (myDal.ChangePassword(SharedData.Instance.Id, tbOld.Text, tbNew.Text, tbReNew.Text))
            {
                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult= DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect input, please re-check filled field", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
