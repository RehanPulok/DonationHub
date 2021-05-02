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

namespace DonationHub
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "")
            {
                

                MessageBox.Show("Please enter a first name!");
            }
            else if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter an username!");
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            else if (COnfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            else if (LastNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a last name!");
            }
            else if (AddressTextBox.Text == "")
            {
                MessageBox.Show("Please enter a last name!");
            }
            else if (MaleRadioButton.Checked == false && FemaleRadioButton.Checked == false)
            {
                MessageBox.Show("Please select a gender!");
            }
            else if (BloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Please enter a last name!");
            }
            else if (TermsCheckbox.Text == null)
            {
                MessageBox.Show("Please enter a last name!");
            }
            else
            {
                if (PasswordTextBox.Text != COnfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Passwords need to be matched");
                }
                else
                {
                    string gender;
                    if (MaleRadioButton.Checked = true)
                    {
                        gender = MaleRadioButton.Text;
                    }
                    else
                    {
                        gender = FemaleRadioButton.Text;
                    }
                    
                    int userType = 2;

                    AdminService adminService = new AdminService();
                    adminService.AddNewUser(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, AddressTextBox.Text, gender, BloodGroupComboBox.Text,null,0, userType);
                    Login login = new Login();
                    login.Show();
                    this.Hide();


                }
            }
        
            


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                if (VolunteerConfirmPasswordTextBox.Text != VoluunteerPasswordTextBox.Text)
                {
                    MessageBox.Show("Passwords need to be matched");
                }
                else
                {
                    int userType = 3;
                    string gender = null;
                    AdminService adminService = new AdminService();
                    int result = adminService.GovtLicenseValidation(Convert.ToInt32(GovtLicenseTextBox.Text), VolunteerNameTextBox.Text);
                    if (result==1)
                    {
                        adminService.AddNewUser(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, AddressTextBox.Text, gender, BloodGroupComboBox.Text, VolunteerNameTextBox.Text, Convert.ToInt32(GovtLicenseTextBox.Text), userType);
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    MessageBox.Show("Invalid Govt License Number or Name");
                    


                }
            }
        }
    }
}
