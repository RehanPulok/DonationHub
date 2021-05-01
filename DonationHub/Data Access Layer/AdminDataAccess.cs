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
        public List<Donor> GetUsers()
        {
            string sql = "SELECT * FROM Donors";
            SqlDataReader reader = this.GetData(sql);
            List<Donor> donors = new List<Donor>();

            while (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorID = Convert.ToInt32(reader["DonorID"]);
                donor.FirstName = reader["FirstName"].ToString();
                donor.Lastname = reader["LastName"].ToString();
                donor.Email = reader["Email"].ToString();
                donor.Username = reader["Username"].ToString();
                donor.Password = reader["Password"].ToString();                
                donor.Gender = reader["Gender"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                donor.DonorID = Convert.ToInt32(reader["DonorID"]);
                donor.Address = reader["Address"].ToString();


                donors.Add(donor);

            }
            return donors;

        }
        public Donor GetUser(int ID)
        {
            string sql = "SELECT * FROM Donors WHERE DonorID = " + ID;
            SqlDataReader reader = this.GetData(sql);
            List<Donor> donors = new List<Donor>();

            if (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorID = Convert.ToInt32(reader["DonorID"]);
                donor.FirstName = reader["FirstName"].ToString();
                donor.Lastname = reader["LastName"].ToString();
                donor.Email = reader["Email"].ToString();
                donor.Username = reader["Username"].ToString();
                donor.Password = reader["Password"].ToString();
                donor.Gender = reader["Gender"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                return donor;

            }

            
            
                
                return null;
            

        }

        public List<VolunteerOrganisation> GetOrganisations()
        {
            string sql = "SELECT * FROM VolunteerOrganisations";
            SqlDataReader reader = this.GetData(sql);
            List<VolunteerOrganisation> volunteerOrganisations = new List<VolunteerOrganisation>();

            while (reader.Read())
            {
                VolunteerOrganisation volunteerOrganisation = new VolunteerOrganisation();
                volunteerOrganisation.OrganisationID = Convert.ToInt32(reader["OrganisationID"]);
                volunteerOrganisation.OrganisationName = reader["OrganisationName"].ToString();
                volunteerOrganisation.Email = reader["Email"].ToString();
                volunteerOrganisation.Username = reader["Username"].ToString();
                volunteerOrganisation.Password = reader["Password"].ToString();
                volunteerOrganisation.GovtLicenseNo = Convert.ToInt32(reader["GovtLicenseNo"]);

                volunteerOrganisations.Add(volunteerOrganisation);

            }
            return volunteerOrganisations;

        }

        public VolunteerOrganisation GetOrganisation(int ID)
        {
            string sql = "SELECT * FROM VolunteerOrganisations WHERE OrganisationID = " + ID;
            SqlDataReader reader = this.GetData(sql);
            List<VolunteerOrganisation> volunteerOrganisations = new List<VolunteerOrganisation>();

            if (reader.Read())
            {
                VolunteerOrganisation volunteerOrganisation = new VolunteerOrganisation();
                volunteerOrganisation.OrganisationID = Convert.ToInt32(reader["OrganisationID"]);
                volunteerOrganisation.OrganisationName = reader["OrganisationName"].ToString();
                volunteerOrganisation.Email = reader["Email"].ToString();
                volunteerOrganisation.Username = reader["Username"].ToString();
                volunteerOrganisation.Password = reader["Password"].ToString();
                volunteerOrganisation.GovtLicenseNo = Convert.ToInt32(reader["GovtLicenseNo"]);
                return volunteerOrganisation;

            }
            return null;
        }
        

        public int DeleteUser(int donorID)
        {
            string sql = "DELETE FROM Donors WHERE DonorID=" + donorID;
            return this.ExecuteQuery(sql);
        }

        public int AddUser(Donor donor)
        {
            string sql = "INSERT INTO Donors (FirstName, Lastname,Email, Username, Password, Gender,BloodGroup) VALUES ('" + donor.FirstName + "','" + donor.Lastname + "','" + donor.Email + "''" + donor.Username + "','" + donor.Password + "','" + donor.Gender + "','" + donor.BloodGroup + "')";
            return this.ExecuteQuery(sql);
        }

        public int AddOrganisation(VolunteerOrganisation volunteerOrganisation)
        {
            string sql = "INSERT INTO VolunteerOrganisations (OrganisationName, Email, Username, Password, GovtLicenseNo) VALUES ('" + volunteerOrganisation.OrganisationName + "','" + volunteerOrganisation.Email + "','" + volunteerOrganisation.Username + "','" + volunteerOrganisation.Password + "','" + volunteerOrganisation.GovtLicenseNo + "')";
            return this.ExecuteQuery(sql);
        }

        public int DeleteOrganisation(int organisationID)
        {
            string sql = "DELETE FROM VolunteerOrganisations WHERE OrganisationID=" + organisationID;
            return this.ExecuteQuery(sql);
        }
    }
}
