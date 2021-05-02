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
        UserDataAccess userDataAccess;

        public AdminService()
        {
            this.adminDataAccess = new AdminDataAccess();
            this.organisationDataAccess = new OrganisationDataAccess();
            this.loginDataAcces = new LoginDataAcces();
            this.userDataAccess = new UserDataAccess();
        }

        public List<User> GetAllUsers()
        {
            this.adminDataAccess = new AdminDataAccess();
            return this.adminDataAccess.GetUsers();
        }


        public int AddNewUser( string firstName, string LastName, string email, string username, string password, string gender, string address, string bloodGroup,string organisationName, int govtLicenseNo, int userType)
        {
            User donor = new User() 
            {
                FirstName = firstName, 
                LastName = LastName, 
                Email = email, 
                Username = username, 
                Password = password, 
                Gender = gender, 
                Address = address, 
                BloodGroup = bloodGroup,
                OrganisationName=organisationName, 
                GovtLicenseNo=govtLicenseNo, 
                UserType= userType 
            };
            OrganisationService organisationService = new OrganisationService();
            return userDataAccess.AddUser(donor);
        }

        public int DeleteUser(int id)
        {
            User user = new User() { ID = id };
            return this.adminDataAccess.DeleteUser(id);
        }
        public int AddNewOrganisation(string firstName, string LastName, string email, string username, string password, string gender, string address, string bloodGroup, string organisationName, int govtLicenseNo, int userType)
        {
            OrganisationService organisationService = new OrganisationService();
            int result =organisationService.GovtLicenseValidation(govtLicenseNo,  organisationName);
            organisationService = new OrganisationService();
            if (result==1)
            {
                User volunteerOrganisation = new User() 
                {
                    FirstName = firstName,
                    LastName = LastName,
                    Email = email,
                    Username = username,
                    Password = password,
                    Gender = gender,
                    Address = address,
                    BloodGroup = bloodGroup,
                    OrganisationName = organisationName,
                    GovtLicenseNo = govtLicenseNo,
                    UserType = userType
                };
                //this.adminDataAccess = new AdminDataAccess();
                return adminDataAccess.AddUser(volunteerOrganisation);
            }
            return -1;
            
        }
        public int DeleteOrganisation(int id)
        {
            User volunteerOrganisation = new User() { ID = id };
            return this.organisationDataAccess.DeleteOrganisation(id);
        }

        

    }
}
