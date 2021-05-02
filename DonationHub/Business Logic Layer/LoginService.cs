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
    class LoginService
    {
        LoginDataAcces loginDataAccess;

        public LoginService()
        {
            this.loginDataAccess = new LoginDataAcces();
        }

        public int LoginValidation(string username, string password)
        {
            User user = new User()
            {
                Username = username,
                Password= password

            };

            return loginDataAccess.UserLoginValidation(user);


            
        }
    }
}
