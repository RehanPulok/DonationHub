using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;

        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }

        public int GetDonor(string username)
        {
            return this.userDataAccess.GetDonorID(username);
        }
        public int GetUserID(string username)
        {
            return this.userDataAccess.GetUserID(username);
        }
        public int UpdateExistingDonor( string firstName, string LastName, string email,  string password, string bloodGroup)
        {
            User donor = new User()
            {
                FirstName = firstName,
                LastName = LastName,
                Email = email,
                
                Password = password,
                
                BloodGroup = bloodGroup
                //ID= id
                
            };
            
            return userDataAccess.UpdateDonor(donor);
        }
    }
}
