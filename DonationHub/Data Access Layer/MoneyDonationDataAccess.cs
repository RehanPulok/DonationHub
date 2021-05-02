using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class MoneyDonationDataAccess:DataAccess
    {
        public int BkashDonation(MoneyDonation moneyDonatation)
        {
            
        }
        public int CardDonation(MoneyDonation moneyDonatation)
        {
            string sql = "SELECT Balance From Users WHERE CardNumber= '" + moneyDonatation.CardNumber + "' AND Pin= '" + moneyDonatation.CardPin + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                return Convert.ToInt32(reader["Amount"]);
            }
            return -1;
        }
        
    }
}
