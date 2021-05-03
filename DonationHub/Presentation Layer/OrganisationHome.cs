using DonationHub.Business_Logic_Layer;
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
        string username;

        public OrganisationHome()
        {
            InitializeComponent();
            //this.username = username;

        }

        public OrganisationHome(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }

        private void OrganisationHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddEventButtonOrganisationHome_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.AddNewEvent(CreateEventTextBox.Text, EventDateTimePicker.Text, Convert.ToInt32(username));
            if (result==1)
            {
                MessageBox.Show("Event Added");
            }
            else
            {
                MessageBox.Show("Failed to add event");
            }
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOrganisation updateOrganisation = new UpdateOrganisation();
            this.Hide();
            updateOrganisation.Show();
        }

        private void OrganisationHome_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            IDTextBox.Text= userService.GetUserID(username).ToString();
            
        }

        private void EventDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EventNameTextBox.Text = EventDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            EventIDTextBox.Text= EventDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void LogoutButtonOrganisationHome_Click(object sender, EventArgs e)
        {

        }

        private void UpdateEventButtonOrganisationHome_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteEventButtonOrganisationHome_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.DeleteEvent(Convert.ToInt32(EventIDTextBox.Text));
            if (result == 1)
            {
                MessageBox.Show("Event Deleted");
            }
            else
            {
                MessageBox.Show("Failed to Delete event");
            }
        }
    }
}
