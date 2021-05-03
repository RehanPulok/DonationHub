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
        public int UpdateExistingOrganisation(string email, string password,string organisationName)
        {
            User organisation = new User()
            {
                
                Email = email,
                Password = password,
                
                OrganisationName = organisationName,
                
            };
            
            return organisationDataAccess.UpdateOrganisation(organisation);
        }


    }
    
}
