using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Business_Logic_Layer
{
    class AdminService
    {
        AdminDataAccess adminDataAccess;
        OrganisationDataAccess organisationDataAccess;
        public int AddNewUser(string firstName, string LasttName, string email, string username, string password, string gender, string bloodGroup)
        {
            Donor donor = new Donor() { FirstName = firstName, Lastname = LasttName, Email = email, Username = username, Password = password, Gender = gender, BloodGroup = bloodGroup };
            return this.adminDataAccess.AddUser(donor);
        }

        public int DeleteUser(int id)
        {
            Donor donor = new Donor() { DonorID = id };
            return this.adminDataAccess.DeleteUser(id);
        }
        public int AddNewOrganisation(string OrganisationName, string email, string username, string password, int govtLicenseNO)
        {
            VolunteerOrganisation volunteerOrganisation = new VolunteerOrganisation() { OrganisationName = OrganisationName, Email = email, Username = username, Password = password, GovtLicenseNo = govtLicenseNO };
            return this.organisationDataAccess.AddOrganisation(volunteerOrganisation);
        }
        public int DeleteOrganisation(int id)
        {
            VolunteerOrganisation volunteerOrganisation = new VolunteerOrganisation() { OrganisationID = id };
            return this.organisationDataAccess.DeleteOrganisation(id);
        }
    }
}
