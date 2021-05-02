using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class AdminDataAccess:DataAccess
    {
        public List<User> GetDonors()
        {
            string sql = "SELECT * FROM Users WHERE UserType= "+2;
            SqlDataReader reader = this.GetData(sql);
            List<User> donors = new List<User>();

            while (reader.Read())
            {
                User users = new User();
                users.ID = Convert.ToInt32(reader["ID"]);
                users.FirstName = reader["FirstName"].ToString();
                users.LastName = reader["LastName"].ToString();
                users.Email = reader["Email"].ToString();
                users.Username = reader["Username"].ToString();
                users.Password = reader["Password"].ToString();                
                users.Gender = reader["Gender"].ToString();
                users.BloodGroup = reader["BloodGroup"].ToString();
                
                users.Address = reader["Address"].ToString();
                users.UserType = Convert.ToInt32(reader["UserType"]);


                donors.Add(users);

            }
            return donors;

        }
        public List<User> GetUsers()
        {
            string sql = "SELECT * FROM Users ";
            SqlDataReader reader = this.GetData(sql);
            List<User> donors = new List<User>();

            while (reader.Read())
            {
                User users = new User();
                users.ID = Convert.ToInt32(reader["ID"]);
                users.FirstName = reader["FirstName"].ToString();
                users.LastName = reader["LastName"].ToString();
                users.Email = reader["Email"].ToString();
                users.Username = reader["Username"].ToString();
                users.Password = reader["Password"].ToString();
                users.Gender = reader["Gender"].ToString();
                users.BloodGroup = reader["BloodGroup"].ToString();
                //users.DonorID = Convert.ToInt32(reader["DonorID"]);
                users.Address = reader["Address"].ToString();
                users.OrganisationName = reader["OrganisationName"].ToString();
                //users.GovtLicenseNo = Convert.ToInt32(reader["GovtLicenseNo"]);
                users.UserType = Convert.ToInt32(reader["UserType"]);


                donors.Add(users);

            }
            
            return donors;

        }
        public User GetUser(int ID)
        {
            string sql = "SELECT * FROM Users WHERE ID= " + ID;
            SqlDataReader reader = this.GetData(sql);
            List<User> donors = new List<User>();

            if (reader.Read())
            {
                User users = new User();
                users.ID = Convert.ToInt32(reader["DonorID"]);
                users.FirstName = reader["FirstName"].ToString();
                users.LastName = reader["LastName"].ToString();
                users.Email = reader["Email"].ToString();
                users.Username = reader["Username"].ToString();
                users.Password = reader["Password"].ToString();
                users.Gender = reader["Gender"].ToString();
                users.BloodGroup = reader["BloodGroup"].ToString();
                //users.DonorID = Convert.ToInt32(reader["DonorID"]);
                users.Address = reader["Address"].ToString();
                users.UserType = Convert.ToInt32(reader["UserType"]);

                return users;
                //donors.Add(users);

            }
            




            return null;
            

        }

        public List<User> GetOrganisations()
        {
            string sql = "SELECT * FROM Users WHERE UserType= " + 3;
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = new User();
                user.ID = Convert.ToInt32(reader["ID"]);
                user.OrganisationName = reader["OrganisationName"].ToString();
                user.Email = reader["Email"].ToString();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.GovtLicenseNo = Convert.ToInt32(reader["GovtLicenseNo"]);
                user.UserType = Convert.ToInt32(reader["UserType"]);

                users.Add(user);

            }
            return users;

        }

        public User GetOrganisation(int ID)
        {
            string sql = "SELECT * FROM Users WHERE ID= " + ID;
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = new User();
                user.ID = Convert.ToInt32(reader["ID"]);
                user.OrganisationName = reader["OrganisationName"].ToString();
                user.Email = reader["Email"].ToString();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.GovtLicenseNo = Convert.ToInt32(reader["GovtLicenseNo"]);
                user.UserType = Convert.ToInt32(reader["UserType"]);

                //users.Add(user);
                return user;

            }
            

            return null;
        }
        

        public int DeleteUser(int ID)
        {
            string sql = "DELETE FROM Users WHERE ID=" + ID;
            return this.ExecuteQuery(sql);
        }

        public int AddUser(User user)
        {
            //string sql = "INSERT INTO Users (FirstName, Lastname,Email, Username, Password, Gender,BloodGroup, Address, UserType) VALUES ('" + user.FirstName + "','" + user.LastName + "','" + user.Email + "''" + user.Username + "','" + user.Password + "','" + user.Gender + "','" + user.BloodGroup + "','" + user.Address + "','" + user.UserType + "')";
            string sql = "INSERT INTO Users (FirstName, Lastname,Email, Username, Password, Gender,BloodGroup, Address,OrganisationName, GovtLicenseNo, UserType) VALUES ('" + user.FirstName + "','" + user.LastName + "','" + user.Email + "','" + user.Username + "','" + user.Password + "','" + user.Gender + "','" + user.BloodGroup + "','"+user.Address+"','"+user.OrganisationName+"','"+user.GovtLicenseNo+"','"+user.UserType+"')";
            return this.ExecuteQuery(sql);
        }
        
        

        public int DeleteOrganisation(int organisationID)
        {
            string sql = "DELETE FROM Users WHERE ID=" + organisationID;
            return this.ExecuteQuery(sql);
        }

        

    }
}
