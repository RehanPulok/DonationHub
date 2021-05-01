using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
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
    public partial class OrganisationHome : Form
    {
        public OrganisationHome()
        {
            InitializeComponent();
        }

        private void OrganisationHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddEventButtonOrganisationHome_Click(object sender, EventArgs e)
        {
            OrganisationDataAccess organisationDataAccess = new OrganisationDataAccess();
            //organisationDataAccess.AddOrganisation(VolunteerOrganisation volunteerorganisation);
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOrganisation updateOrganisation = new UpdateOrganisation();
            this.Hide();
            updateOrganisation.Show();
        }

        private void OrganisationHome_Load(object sender, EventArgs e)
        {

        }
    }
}
