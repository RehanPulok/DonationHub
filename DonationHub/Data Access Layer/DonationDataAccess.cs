using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class DonationDataAccess:DataAccess
    {
        public int CheckAmountBkash(MoneyDonation moneyDonation)
        {
            string sql = "SELECT Balance From Bkash WHERE PhoneNumber= '" + moneyDonation.MobileNumber + "' AND Pin= '" + moneyDonation.BkashPin + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                return Convert.ToInt32(reader["Balance"]);
            }
            return -1;

            /*
            string sql = "SELECT DonationID From Donations WHERE DonorId= '" + donation.DonorID + "' AND OrganisationID= '" + donation.OrganisationID + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                return Convert.ToInt32(reader["Amount"]);
            }
            return -1;
            */
        }
        public int CheckAmountCard(MoneyDonation moneyDonation)
        {
            string sql = "SELECT Balance From BankAccount WHERE CardNumber= '" + moneyDonation.CardNumber + "' AND Pin= '" + moneyDonation.BkashPin + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                return Convert.ToInt32(reader["Balance"]);
            }
            return -1;
        }
            public int MakeDonation(Donation donation)
        {
            string sql = "INSERT INTO Donations (DonorID, OrganisationID, Amount, Food) VALUES ('"+donation.DonorID+"','"+donation.OrganisationID+"','"+donation.Amount+"','"+donation.Food+"') ";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                return Convert.ToInt32(reader["Amount"]);
            }
            return -1;
        }
    }
}
