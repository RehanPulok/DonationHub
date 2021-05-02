using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class UserDataAccess:DataAccess
    {
        public int GetDonorID(string username)
        {
            string sql = "SELECT ID FROM Users WHERE Username= '" + username+"'AND UserType= '"+2+"'";
            SqlDataReader reader = this.GetData(sql);            
            if (reader.Read())
            {           
                             
                 return Convert.ToInt32(reader["ID"]);
                
            }

            return -1;

        }
        /*
        public int GetDonorUsername(int id)
        {
            string sql = "SELECT ID FROM Users WHERE Username= '" + username + "'AND UserType= '" + 2 + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                return Convert.ToInt32(reader["ID"]);

            }

            return -1;

        }
        */
    }
}
