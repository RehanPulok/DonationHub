using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonationHub.Presentation_Layer
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void LogoutButtonDeleteUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void BackButtonUserDelete_Click(object sender, EventArgs e)
        {
            AdminHome organisationHome = new AdminHome();
            this.Hide();
            organisationHome.Show();
        }
    }
}
