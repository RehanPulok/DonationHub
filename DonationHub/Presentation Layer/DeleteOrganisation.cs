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

        private void DeleteOrganisationButton_Click(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            organisationService.DeleteOrganisation(Convert.ToInt32(SearchOrganisationTextBox.Text));
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
    }
}
