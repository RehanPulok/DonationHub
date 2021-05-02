using DonationHub.Business_Logic_Layer;
using DonationHub.Data_Access_Layer;
using DonationHub.Presentation_Layer;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pp(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            int result = loginService.LoginValidation(UserNameTextBox.Text, PasswordTextBox.Text);
            if (result==1)
            {
                LoginDataAcces loginDataAccess = new LoginDataAcces();
                AdminHome adminHome = new AdminHome();
                this.Hide();
                adminHome.Show();
            }
            else if (result==2)
            {
                LoginDataAcces loginDataAccess = new LoginDataAcces();
                ViewOrganisation viewOrganisation = new ViewOrganisation();
                this.Hide();
                viewOrganisation.Show();
            }
            else if (result==3)
            {
                LoginDataAcces loginDataAccess = new LoginDataAcces();
                OrganisationHome organisationHome = new OrganisationHome();
                this.Hide();
                organisationHome.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
        }
    }
}
