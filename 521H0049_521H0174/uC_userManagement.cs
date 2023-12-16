using _521H0049_521H0174.Models;
using DevExpress.XtraReports.Native;
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
    public partial class uC_userManagement : UserControl
    {

        private readonly myDAL myDal = new myDAL();

        public static uC_userManagement instance;
        public string _instanceUsername;
        public string _instanceFullName;
        public string _instancePhone;
        public int _instanceAge;
        public string _instanceStatus;



        public uC_userManagement()
        {
            InitializeComponent();
            instance = this;
            LoadUserData();
            FillFilterOptions();
        }

        private void LoadUserData()
        {
            DGV_userData.DataSource = myDal.GetAllUsers();
            DGV_userData.Refresh();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            frmAddUser f = new frmAddUser();
            
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                LoadUserData();
            }
            FillFilterOptions();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (DGV_userData.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int userIdToDelete = (int)DGV_userData.SelectedRows[0].Cells["UserID"].Value;
                    await myDal.DeleteUser(userIdToDelete);

                    LoadUserData();
                }
            }
        }

        private async void btn_adjust_Click(object sender, EventArgs e)
        {
            
            if (DGV_userData.SelectedRows.Count > 0)
            {
                int userIdToUpdate = (int)DGV_userData.SelectedRows[0].Cells["UserID"].Value;

                string name, phone, status,fullname;
                int age,_id;

                _id = int.Parse(DGV_userData.SelectedRows[0].Cells["UserID"].Value.ToString());
                name = DGV_userData.SelectedRows[0].Cells["Username"].Value.ToString();
                fullname = DGV_userData.SelectedRows[0].Cells["FullName"].Value.ToString();
                phone = DGV_userData.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                age = int.Parse(DGV_userData.SelectedRows[0].Cells["Age"].Value.ToString());
                status = DGV_userData.SelectedRows[0].Cells["Status"].Value.ToString();
                

                frmAdjustUser userCRUDs = new frmAdjustUser(name, fullname,phone, age,status);

                if (userCRUDs.ShowDialog() == DialogResult.OK)
                {

                    User updatedUser = new User
                    {
                        UserID = _id,
                        Username = _instanceUsername,
                        FullName= _instanceFullName,
                        PhoneNumber = _instancePhone,
                        Age = _instanceAge,
                        Status = _instanceStatus
                    };

                    await myDal.UpdateUser(updatedUser);

                    LoadUserData();
                    FillFilterOptions();
                }
                
            }
        }

        private void optionChanged(object sender, EventArgs e)
        {
            string selectedFilter = cbx_filterOption.SelectedItem.ToString();

            
            if (selectedFilter == "Show All")
            {
                LoadUserData();
            }
            else
            {
                DGV_userData.DataSource = myDal.GetUsersByRole(selectedFilter);
                DGV_userData.Refresh();
            }
        }

        private void FillFilterOptions()
        {
            cbx_filterOption.Items.Clear();

            cbx_filterOption.Items.Add("Show All");

            List<string> userRoles = myDal.GetAllUserRoles();
            cbx_filterOption.Items.AddRange(userRoles.ToArray());

            cbx_filterOption.SelectedIndex = 0;
        }
    }
}
