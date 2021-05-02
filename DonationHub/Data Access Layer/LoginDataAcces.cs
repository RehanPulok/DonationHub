using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class LoginDataAcces:DataAccess

    {
        public int UserLoginValidation(User user)
        {
            
            
            string sql= "SELECT UserType From Users WHERE Username= '"+user.Username+"' AND Password= '"+user.Password+"'";
            SqlDataReader reader =this.GetData(sql);
            if (reader.Read())
            {

                int result=  Convert.ToInt32(reader["UserType"]);
                return result;
            }
            return -1;
          
        }

        

    }
}
