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
    public partial class AddOrganisation : Form
    {
        public AddOrganisation()
        {
            InitializeComponent();
        }
        /*
        private void AddButton_Click(object sender, EventArgs e)
        {
            AdminService adminService = new AdminService();
            int result= adminService.AddNewOrganisation(VolunteerNameTextBox.Text, VolunteerUsernameTextBox.Text, VolunteerEmailTextBox.Text, VoluunteerPasswordTextBox.Text, Convert.ToInt32(GovtLicenseTextBox.Text),3);
            if (result>0)
            {
                MessageBox.Show("Volunteer Organisation added successfully");
                Admin admin = new Admin();
                this.Hide();
                admin.UpdateOrganisations();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Error in adding Volunteer Organisation.");
                Admin admin = new Admin();
                this.Hide();
                admin.UpdateOrganisations();
                admin.Show();
            }
        }
        */

        private void BackButtonAdmin_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButtonAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
