using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer.Entities
{
    class User
    {
        

        public int ID { get; set; }
        public string FirstName { get; set ; }
        




        
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        
        
        public string OrganisationName { get; set; }
        

        public int GovtLicenseNo { get; set; }
        
        public int UserType { get; set; }
    }
}
