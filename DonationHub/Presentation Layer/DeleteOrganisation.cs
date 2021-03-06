using DonationHub.Business_Logic_Layer;
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
    public partial class DeleteOrganisation : Form
    {
        public DeleteOrganisation()
        {
            InitializeComponent();
        }

        

        private void LogoutButtonDeleteOrganisation_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void BackDeleteButton_Click(object sender, EventArgs e)
        {
            OrganisationHome organisationHome = new OrganisationHome();
            this.Hide();
            organisationHome.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteOrganisationButton_Click(object sender, EventArgs e)
        {
            AdminService adminService = new AdminService();
            int result = adminService.DeleteUser(Convert.ToInt32(SearchOrganisationTextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("User Deleted Successfully");
                AdminHome adminHome = new AdminHome();
                this.Hide();
                adminHome.Show();
            }
            else
            {
                MessageBox.Show("Error");
                AdminHome adminHome = new AdminHome();
                this.Hide();
                adminHome.Show();
            }
        }
        

    }
}
