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
    public partial class Organisation : Form
    {
        public Organisation()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DonateMoneyButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            this.Hide();
            payment.Show();
        }

        private void Biddyanando_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DonateFoodButton_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            this.Hide();
            food.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /*
        private void Organisation_Load(object sender, EventArgs e)
        {
            OrganisationService organisationService = new OrganisationService();
            EventDataGridView.DataSource = organisationService.GetAllVolunteerOrganisations();
        }
        */
    }
}
