using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProteinTrackerClient.ProteinTrackerService;

namespace ProteinTrackerClient
{
    public partial class ProtienTrackerFrom : Form
    {
        private ProteinTrackerWebServiceSoapClient service = new ProteinTrackerWebServiceSoapClient();

        private User[] users;

        public ProtienTrackerFrom()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            users = service.UsersList();
            cboSelectUser.DataSource = users;
            cboSelectUser.DisplayMember = "Name";
            cboSelectUser.ValueMember = "UserID";
        }

        private void OnAddNewUser(object sender, EventArgs e)
        {
            service.AddUser(txtNewUserName.Text, int.Parse(txtNewUserGoal.Text));
            users = service.UsersList();
            cboSelectUser.DataSource = users;

            txtNewUserName.Clear();
            txtNewUserGoal.Clear();
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            var index = cboSelectUser.SelectedIndex;
            lblProteinTotalDisplay.Text = users[index].Total.ToString();
            lblProteinGoalDisplay.Text = users[index].Goal.ToString();
        }

        async private void OnAddProtein(object sender, EventArgs e)
        {
            try
            {
                var userID = users[cboSelectUser.SelectedIndex].UserID;
                var newTotal = await service.AddProteinAsync(int.Parse(txtProteinAmount.Text), userID);

                users[cboSelectUser.SelectedIndex].Total = newTotal;
                lblProteinTotalDisplay.Text = newTotal.ToString();
            }
            catch(FaultException fe)
            {
                Console.WriteLine("Exception: " + fe.Message);
            }
            
        }
    }
}
