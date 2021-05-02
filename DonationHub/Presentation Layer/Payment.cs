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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            DonationService donationDataAccess = new DonationService();
            
            //int result1 = donationDataAccess.DonateByBkash(Convert.ToInt64(PhoneNumberTextBox.Text),Convert.ToInt32(AmountTextBox.Text), Convert.ToInt32(PinTextBox.Text));
            int result = donationDataAccess.CheckAmountBkash(Convert.ToInt32( DonorIDTextBox.Text), Convert.ToInt32(OrganisationIDTextBox.Text));
            if (result> Convert.ToInt32(AmountTextBox.Text))
            {
                donationDataAccess.MakeDonation(Convert.ToInt32(DonorIDTextBox.Text), Convert.ToInt32(OrganisationIDTextBox.Text), Convert.ToInt32(AmountTextBox.Text), null);
            }
            MessageBox.Show("You don't have sufficient balance!");
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Organisation org = new Organisation();
            org.Show();
            this.Hide();
        }

        private void BkashBackButton_Click(object sender, EventArgs e)
        {
            Organisation org = new Organisation();
            org.Show();
            this.Hide();
        }

        private void DonorIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardPaymentButton_Click(object sender, EventArgs e)
        {
            DonationService donationDataAccess = new DonationService();

            int result1 = donationDataAccess.DonateByCard(Convert.ToInt64(CardNoTextBox.Text),Convert.ToInt32(CardAmountTextBox.Text), Convert.ToInt32(CardPinTextBox.Text));
            int result = donationDataAccess.CheckAmountCard(Convert.ToInt32(DonorIDTextBox.Text), Convert.ToInt32(OrganisationIDTextBox.Text));
            if (result > Convert.ToInt32(CardAmountTextBox.Text))
            {
                donationDataAccess.MakeDonation(Convert.ToInt32(DonorIDTextBox.Text), Convert.ToInt32(OrganisationIDTextBox.Text), Convert.ToInt32(AmountTextBox.Text), null);
            }
            MessageBox.Show("You don't have sufficient balance!");
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            UserService usersevice = new UserService();
            OrganisationService organisationService = new OrganisationService();
            Login login = new Login();
            //Convert.ToInt32(DonorIDTextBox.Text) = usersevice.GetDonor(login.UserNameTextBox.Text);
        }
    }
}
