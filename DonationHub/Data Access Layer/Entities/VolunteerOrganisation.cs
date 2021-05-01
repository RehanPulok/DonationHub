using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer.Entities
{
    class VolunteerOrganisation
    {
        public int OrganisationID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public string OrganisationName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int GovtLicenseNo { get; set; }

    }
}
