using DonationHub.Business_Logic_Layer;
using DonationHub.Data_Access_Layer;
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
    public partial class UpdateOrganisation : Form
    {
        public UpdateOrganisation()
        {
            InitializeComponent();
        }

        private void UpdateOrganisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateButtonOrganisationHome_Click(object sender, EventArgs e)
        {
            string email = VolunteerEmailTextBox.Text;
            if (VolunteerNameTextBox.Text == "")
            {

                MessageBox.Show("Please enter a Organisation name!");
            }
            
            else if (VoluunteerPasswordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            else if (VolunteerConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            
            else
            {
                if (email.Contains("@gmail.com") || email.Contains("@outlook.com") || email.Contains("@yahoo.com"))
                { 
                    if (VolunteerConfirmPasswordTextBox.Text != VoluunteerPasswordTextBox.Text)
                    {
                        MessageBox.Show("Passwords need to be matched");
                    }
                    else
                    {
                        OrganisationService organisationService = new OrganisationService();
                        int result = organisationService.UpdateExistingOrganisation(VolunteerEmailTextBox.Text, VoluunteerPasswordTextBox.Text, VolunteerNameTextBox.Text);
                        if (result == 1)
                        {

                            MessageBox.Show("Volunteer organisation Updated");
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Update Failed");
                        }




                    }
                }
                else
                {
                    MessageBox.Show("Invalid email");     
                }
            }
            
        }

        /*
        private void UpdateButtonOrganisationHome_Click(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            organisationService.UpdateExistingOrganisation(VolunteerNameTextBox.Text, VolunteerUsernameTextBox.Text, VolunteerEmailTextBox.Text, VoluunteerPasswordTextBox.Text, Convert.ToInt32( GovtLicenseTextBox.Text) );
        }
        */
    }
}
