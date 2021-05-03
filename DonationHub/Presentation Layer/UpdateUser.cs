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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void HomeUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            if (FirstNameTextBox.Text == "")
            {


                MessageBox.Show("Please enter a first name!");
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

            else if (BloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Please select blood group");
            }

            else
            {
                if (email.Contains("@gmail.com") || email.Contains("@outlook.com") || email.Contains("@yahoo.com"))
                {
                    if (PasswordTextBox.Text != COnfirmPasswordTextBox.Text)
                    {
                        MessageBox.Show("Passwords need to be matched");
                    }
                    else
                    {
                        UserService userService = new UserService();
                        int result = userService.UpdateExistingDonor(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text, BloodGroupComboBox.Text);
                        if (result == 1)
                        {
                            MessageBox.Show("User Updated");
                        }
                        else
                        {
                            MessageBox.Show("Update failed");

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }
                
            }
   }    }
}
