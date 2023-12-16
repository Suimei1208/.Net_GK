using _521H0049_521H0174.Models;
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
    public partial class uC_userLoginHistory : UserControl
    {
        private readonly myDAL myDal = new myDAL();
        public uC_userLoginHistory()
        {
            InitializeComponent();
            FillFilterOptions();
        }

        private void FillFilterOptions()
        {
            cbx_filterOption.Items.Clear();

            cbx_filterOption.Items.Add("Show All");

            List<KeyValuePair<int, string>> users = myDal.GetFilterData();
            cbx_filterOption.Items.AddRange(users.Select(u => (object)u).ToArray());

            cbx_filterOption.SelectedIndex = 0;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if (cbx_filterOption.SelectedIndex > 0)
            {
                KeyValuePair<int, string> selectedUser = (KeyValuePair<int, string>)cbx_filterOption.SelectedItem;
                int userId = selectedUser.Key;

                List<object> loginHistory = myDal.GetLoginHistoryByUserId(userId);
                DGV_logHistory.DataSource = loginHistory;
            }
            else
            {
                List<object> loginHistory = myDal.GetLoginHistory();
                DGV_logHistory.DataSource = loginHistory;
            }
        }
    }
}
