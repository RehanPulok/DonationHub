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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string email = VolunteerEmailTextBox.Text;
            if (VolunteerNameTextBox.Text == "")
            {

                MessageBox.Show("Please enter a Organisation name!");
            }
            else if (VolunteerUsernameTextBox.Text == "")
            {
                MessageBox.Show("Please enter an username!");
            }
            else if (VoluunteerPasswordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            else if (VolunteerConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            else if (GovtLicenseTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Govt license number!");
            }
            else if (VolunteerTermsCheckBox.Text == "")
            {
                MessageBox.Show("Please agree to terms & conditions!");
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
                        int userType = 3;
                        //string gender = null;

                        AdminService adminService = new AdminService();
                        int result = adminService.AddNewOrganisation(null, null, VolunteerEmailTextBox.Text, VolunteerUsernameTextBox.Text, VoluunteerPasswordTextBox.Text, null, null, null, VolunteerNameTextBox.Text, Convert.ToInt32(GovtLicenseTextBox.Text), userType);
                        //int result = adminService.GovtLicenseValidation(Convert.ToInt32(GovtLicenseTextBox.Text), VolunteerNameTextBox.Text);
                        if (result == 1)
                        {
                            /*
                            adminService.AddNewUser(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, AddressTextBox.Text, gender, BloodGroupComboBox.Text, VolunteerNameTextBox.Text, Convert.ToInt32(GovtLicenseTextBox.Text), userType);
                            MessageBox.Show("New Organisation added");

                            */
                            MessageBox.Show("Volunteer organisation Added");
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Govt License Number or Name");
                        }




                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }
                
            }
        }
    }
}
