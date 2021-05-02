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
    public partial class ViewOrganisation : Form
    {
        public ViewOrganisation()
        {
            InitializeComponent();
        }

        private void ViewOrganisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /*
        private void BackButtonViewOrganisation_Click(object sender, EventArgs e)
        {
            UpdateUser homeUser = new UpdateUser();
            homeUser.Show();
            this.Hide();
        }
        */
        

        private void LogoutButtonViewOrganisation_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        /*
        private void ViewOrganisation_Load(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            EventDataGridView.DataSource= organisationService.GetAllVolunteerOrganisations();
        }
        */

        private void EventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            this.Hide();
            updateUser.Show();
        }

        private void ViewOrganisation_Load(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            EventDataGridView.DataSource= organisationService.GetAllVolunteerOrganisations();
        }

        private void searchOrganisationByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerachOrganisaiton searchorganisation = new SerachOrganisaiton();
            this.Hide();
            searchorganisation.Show();
        }
    }
}
