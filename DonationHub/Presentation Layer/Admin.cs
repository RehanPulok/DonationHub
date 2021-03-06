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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddOrganisationButtonAdminHome_Click(object sender, EventArgs e)
        {
            AddOrganisation addOrganisation = new AddOrganisation();
            this.Hide();
            addOrganisation.Show();
        }

        private void DeleteOrganisationButtonAdminHome_Click(object sender, EventArgs e)
        {
            DeleteOrganisation deleteOrganisation = new DeleteOrganisation();
            deleteOrganisation.Show();
            this.Hide();
        }

        private void LogoutButtonAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void BackButtonAdmin_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
        /*
        private void Admin_Load(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            OrganisationListDataGridView.DataSource= organisationService.GetAllVolunteerOrganisations();
        }

        public void UpdateOrganisations()
        {
            OrganisationService organisationService = new OrganisationService();
            OrganisationListDataGridView.DataSource= organisationService.GetAllVolunteerOrganisations();
        }
        */

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OrganisationListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            OrganisationListDataGridView.DataSource= organisationService.GetAllVolunteerOrganisations();
        }
    }
}
