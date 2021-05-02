using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer.Entities
{
    class MoneyDonation
    {
        public long CardNumber { get; set; }
        public int CardPin { get; set; }
        public int CardAmount { get; set; }
        public long MobileNumber { get; set; }
        public int BkashPin { get; set; }
        public int BkashAmount { get; set; }

    }
}
