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
        public int GetUserID(string username)
        {
            string sql = "SELECT ID FROM Users WHERE Username= '" + username + "'AND UserType= '" + 3 + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {

                return Convert.ToInt32(reader["ID"]);

            }

            return -1;

        }

        public int AddUser(User user)
        {
            //string sql = "INSERT INTO Users (FirstName, Lastname,Email, Username, Password, Gender,BloodGroup, Address, UserType) VALUES ('" + user.FirstName + "','" + user.LastName + "','" + user.Email + "''" + user.Username + "','" + user.Password + "','" + user.Gender + "','" + user.BloodGroup + "','" + user.Address + "','" + user.UserType + "')";
            string sql = "INSERT INTO Users (FirstName, Lastname,Email, Username, Password, Gender,BloodGroup, Address,OrganisationName, GovtLicenseNo, UserType) VALUES ('" + user.FirstName + "','" + user.LastName + "','" + user.Email + "','" + user.Username + "','" + user.Password + "','" + user.Gender + "','" + user.BloodGroup + "','" + user.Address + "','" + user.OrganisationName + "','" + user.GovtLicenseNo + "','" + user.UserType + "')";
            return this.ExecuteQuery(sql);
        }

        public int UpdateDonor(User user)
        {
            
            string sql = "UPDATE Users SET FirstName='"+user.FirstName+"', Lastname='"+user.LastName+"',Email= '"+user.Email+"', Password= '"+user.Password+"',BloodGroup = '"+user.BloodGroup+ "' WHERE ID= "+user.ID;
            //string sql = "INSERT INTO Users (FirstName, Lastname,Email, Username, Password, Gender,BloodGroup, Address,OrganisationName, GovtLicenseNo, UserType) VALUES ('" + user.FirstName + "','" + user.LastName + "','" + user.Email + "','" + user.Username + "','" + user.Password + "','" + user.Gender + "','" + user.BloodGroup + "','" + user.Address + "','" + user.OrganisationName + "','" + user.GovtLicenseNo + "','" + user.UserType + "')";
            return this.ExecuteQuery(sql);
        }
    }
}
