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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void organisationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();

        }

        private void UserListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void DeleteUserButtonAdminHome_Click(object sender, EventArgs e)
        {

        }
    }
}
