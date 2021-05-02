using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer.Entities
{
    class Donation
    {
        public int DonationID { get; set; }
        public int DonorID { get; set; }
        public int OrganisationID { get; set; }
        public int Amount { get; set; }
        public string Food { get; set; }
    }
}
