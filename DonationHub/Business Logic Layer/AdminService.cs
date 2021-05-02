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
        LoginDataAcces loginDataAcces;

        public AdminService()
        {
            this.adminDataAccess = new AdminDataAccess();
            this.organisationDataAccess = new OrganisationDataAccess();
            this.loginDataAcces = new LoginDataAcces();
        }

        public List<User> GetAllUsers()
        {
            return this.adminDataAccess.GetUsers();
        }


        public int AddNewUser( string firstName, string LastName, string email, string username, string password, string gender, string address, string bloodGroup,string organisationName, int govtLicenseNo, int userType)
        {
            User donor = new User() { FirstName = firstName, LastName = LastName, Email = email, Username = username, Password = password, Gender = gender, Address = address, BloodGroup = bloodGroup,OrganisationName=organisationName, GovtLicenseNo=govtLicenseNo, UserType= userType };
            return this.adminDataAccess.AddUser(donor);
        }

        public int DeleteUser(int id)
        {
            User user = new User() { ID = id };
            return this.adminDataAccess.DeleteUser(id);
        }
        public int AddNewOrganisation( string OrganisationName, string email, string username, string password, int govtLicenseNO, int userType)
        {
            User volunteerOrganisation = new User() { OrganisationName = OrganisationName, Email = email, Username = username, Password = password, GovtLicenseNo = govtLicenseNO, UserType = userType };
            return this.organisationDataAccess.AddOrganisation(volunteerOrganisation);
        }
        public int DeleteOrganisation(int id)
        {
            User volunteerOrganisation = new User() { ID = id };
            return this.organisationDataAccess.DeleteOrganisation(id);
        }

        public int GovtLicenseValidation(int govtLicenseNo, string organisationName  )
        {
            GovtListOfVolunteerOrganisation govtListOfVolunteerOrganisation = new GovtListOfVolunteerOrganisation()
            {
                GovtLicenseNo = govtLicenseNo,
                OrganisationName= organisationName
                 

                

            };

            return adminDataAccess.OrganisationLoginValidation(govtListOfVolunteerOrganisation);



        }

    }
}
