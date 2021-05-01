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
            OrganisationService organisationService = new OrganisationService();
            organisationService.UpdateExistingOrganisation(VolunteerNameTextBox.Text, VolunteerUsernameTextBox.Text, VolunteerEmailTextBox.Text, VoluunteerPasswordTextBox.Text, Convert.ToInt32( GovtLicenseTextBox.Text) );
        }
    }
}
