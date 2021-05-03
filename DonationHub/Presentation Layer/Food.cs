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
    public partial class Food : Form
    {
        string username;
        int id;
        public Food(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public Food(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public Food()
        {
            InitializeComponent();
            //this.username = username;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Food_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Organisation org = new Organisation();
            org.Show();
            this.Hide();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            OrganisationIDTextBox.Text = id.ToString();
            UserService userService = new UserService();
            DonorIDTextBox.Text = userService.GetDonor(username).ToString();
        }
    }
}
