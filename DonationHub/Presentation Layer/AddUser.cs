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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome organisationHome = new AdminHome();
            this.Hide();
            organisationHome.Show();
        }

        private void AddButtonUser_Click(object sender, EventArgs e)
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
                    adminService.AddNewUser(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, AddressTextBox.Text, gender, BloodGroupComboBox.Text, null, 0, userType);
                    Login login = new Login();
                    login.Show();
                    this.Hide();


                }
            }
        }
    }
}
