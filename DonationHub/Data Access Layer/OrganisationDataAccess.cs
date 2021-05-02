using DonationHub.Data_Access_Layer.Entities;
using DonationHub.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class OrganisationDataAccess:DataAccess
    {
        public List<User> GetOrganisations()
        {
            string sql = "SELECT ID,OrganisationName,Email FROM Users WHERE UserType= "+3;
            SqlDataReader reader = this.GetData(sql);
            List<User> volunteerOrganisations = new List<User>();

            while (reader.Read())
            {
                User volunteerOrganisation = new User();
                volunteerOrganisation.ID = Convert.ToInt32(reader["ID"]);
                volunteerOrganisation.OrganisationName = reader["OrganisationName"].ToString();
                volunteerOrganisation.Email = reader["Email"].ToString();
                //volunteerOrganisation.Username = reader["Username"].ToString();
                //volunteerOrganisation.Password = reader["Password"].ToString();
                //volunteerOrganisation.GovtLicenseNo = Convert.ToInt32(reader["GovtLicenseNo"]);

                volunteerOrganisations.Add(volunteerOrganisation);
                
            }
            return volunteerOrganisations;

        }

        internal void AddOrganisation(object User, object user)
        {
            throw new NotImplementedException();
        }

        public User GetOrganisation(int organisationID)
        {
            string sql = "SELECT * FROM Users WHERE ID = "+organisationID;
            SqlDataReader reader = this.GetData(sql);
            List<User> volunteerOrganisations = new List<User>();

            if (reader.Read())
            {
                User volunteerOrganisation = new User();
                volunteerOrganisation.ID = Convert.ToInt32(reader["ID"]);
                volunteerOrganisation.OrganisationName = reader["OrganisationName"].ToString();
                volunteerOrganisation.Email = reader["Email"].ToString();
                //volunteerOrganisation.Username = reader["Username"].ToString();
                //volunteerOrganisation.Password = reader["Password"].ToString();
                //volunteerOrganisation.GovtLicenseNo = Convert.ToInt32(reader["GovtLicenseNo"]);
                return volunteerOrganisation;
                
            }
            //volunteerOrganisations.Add(volunteerOrganisation);
            return null;

        }
        public int SearchOrganisation(int organisationID)
        {
            string sql = "SELECT * FROM Users WHERE ID = " + organisationID;
            SqlDataReader reader = this.GetData(sql);
            ;

            if (reader.Read())
            {
                return 1;

            }
            //volunteerOrganisations.Add(volunteerOrganisation);
            return -1;

        }

        
        public int UpdateOrganisation(User volunteerOrganisation)
        {
            string sql = "UPDATE Users SET OrganisationName = '" + volunteerOrganisation.OrganisationName + "', Email= '" + volunteerOrganisation.Email + "', Username='" + volunteerOrganisation.Username + "', Password='" + volunteerOrganisation.Password + "', GovtLicenseNo='" + volunteerOrganisation.GovtLicenseNo + "' WHERE ID=" + volunteerOrganisation.ID;
            return this.ExecuteQuery(sql);
        }
        public int DeleteOrganisation(int organisationID)
        {
            string sql = "DELETE FROM Users WHERE ID=" + organisationID;
            return this.ExecuteQuery(sql);
        }
        public int GetOrganisationID(string username)
        {
            string sql = "SELECT ID FROM Users WHERE Username= '" + username + "'AND UserType= '" + 3 + "'";
            SqlDataReader reader = this.GetData(sql);            
            if (reader.Read())
            {
                return Convert.ToInt32(reader["ID"]);

            }
            return -1;
        }
        public int AddOrganisation(User user)
        {
            string sql = "INSERT INTO Users (OrganisationName, Email, Username, Password, GovtLicenseNo, UserType) VALUES ('" + user.OrganisationName + "','" + user.Email + "','" + user.Username + "','" + user.Password + "','" + user.GovtLicenseNo + "','" + user.UserType + "')";
            return this.ExecuteQuery(sql);
        }
        public int OrganisationLoginValidation(GovtListOfVolunteerOrganisation govtListOfVolunteerOrganisation)
        {


            string sql = "SELECT OrganistionName From GovtListOfVolunteerOrganisation WHERE GovtLicenseNo= " + govtListOfVolunteerOrganisation.GovtLicenseNo;
            SqlDataReader reader = this.GetData(sql);

            if (reader.Read())
            {

                return 1;

            }
            return -1;


        }

    }
}
