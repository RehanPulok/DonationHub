using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Business_Logic_Layer
{
    class OrganisationService
    {
        OrganisationDataAccess organisationDataAccess ;
        //UserDataAccess userDataAccess;

        public OrganisationService()
        {
            this.organisationDataAccess = new OrganisationDataAccess();
            //this.userDataAccess = new UserDataAccess();
        }

        public object OrganisationDataAccess { get; private set; }

        
        public List<User> GetAllVolunteerOrganisations()
        {
            return this.organisationDataAccess.GetOrganisations();
        }
        public User GetVolunteerOrganisation(int organisationID)
        {
            return this.organisationDataAccess.GetOrganisation(organisationID);
        }
        public int GetSearchedOrganisation(int organisationID)
        {
            return this.organisationDataAccess.SearchOrganisation(organisationID);
        }

        public int UpdateExistingOrganisation(string OrganisationName, string email, string username, string password, int govtLicenseNO)
        {
            User user = new User() { OrganisationName = OrganisationName, Email = email, Username = username, Password = password, GovtLicenseNo = govtLicenseNO };
            //OrganisationID
            return this.organisationDataAccess.UpdateOrganisation(user);
        }
        public int GetOrganisation(string username)
        {
            return this.organisationDataAccess.GetOrganisationID(username);
        }
        public int GovtLicenseValidation(int govtLicenseNo, string organisationName)
        {
            
            GovtListOfVolunteerOrganisation govtListOfVolunteerOrganisation = new GovtListOfVolunteerOrganisation()
            {
                GovtLicenseNo = govtLicenseNo,
                OrganisationName = organisationName


            };
            //this.organisationDataAccess = new OrganisationDataAccess();

            return organisationDataAccess.OrganisationLoginValidation(govtListOfVolunteerOrganisation);

             


        }


    }
    
}
