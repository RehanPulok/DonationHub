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

        internal void AddOrganisation(object volunteerOrganisation, object volunteerorganisation)
        {
            throw new NotImplementedException();
        }

        public VolunteerOrganisation GetOrganisation(int organisationID)
        {
            string sql = "SELECT * FROM VolunteerOrganisations WHERE OrganisationID = "+organisationID;
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
            //volunteerOrganisations.Add(volunteerOrganisation);
            return null;

        }

        public int AddOrganisation(VolunteerOrganisation volunteerOrganisation)
        {
            string sql = "INSERT INTO VolunteerOrganisations (OrganisationName, Email, Username, Password, GovtLicenseNo) VALUES ('" + volunteerOrganisation.OrganisationName + "','" + volunteerOrganisation.Email + "','" + volunteerOrganisation.Username + "','" + volunteerOrganisation.Password + "','" + volunteerOrganisation.GovtLicenseNo + "')";
            return this.ExecuteQuery(sql);
        }
        public int UpdateOrganisation(VolunteerOrganisation volunteerOrganisation)
        {
            string sql = "UPDATE VolunteerOrganisations SET OrganisationName = '" + volunteerOrganisation.OrganisationName + "', Email= '" + volunteerOrganisation.Email + "', Username='" + volunteerOrganisation.Username + "', Password='" + volunteerOrganisation.Password + "', GovtLicenseNo='" + volunteerOrganisation.GovtLicenseNo + "' WHERE OrganisationID=" + volunteerOrganisation.OrganisationID;
            return this.ExecuteQuery(sql);
        }
        public int DeleteOrganisation(int organisationID)
        {
            string sql = "DELETE FROM VolunteerOrganisations WHERE OrganisationID=" + organisationID;
            return this.ExecuteQuery(sql);
        }

    }
}
