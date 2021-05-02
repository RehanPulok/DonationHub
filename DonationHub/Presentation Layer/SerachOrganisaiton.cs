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
    public partial class SerachOrganisaiton : Form
    {
        public SerachOrganisaiton()
        {
            InitializeComponent();
        }

        private void SerachOrganisaiton_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButtonSearchOrganisation_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void BackSearchButton_Click(object sender, EventArgs e)
        {
            ViewOrganisation viewOrganisation = new ViewOrganisation();
            this.Hide();
            viewOrganisation.Show();
        }

        private void SearchOrganisationButton_Click(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            int result= organisationService.GetSearchedOrganisation(Convert.ToInt32(SearchOrganisationTextBox.Text));
            if (result>0)
            {
                Organisation organisation = new Organisation();
                this.Hide();
                organisation.Show();
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }
    }
}
