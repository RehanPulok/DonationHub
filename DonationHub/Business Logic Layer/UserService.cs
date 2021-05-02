using DonationHub.Data_Access_Layer;
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
    }
}
