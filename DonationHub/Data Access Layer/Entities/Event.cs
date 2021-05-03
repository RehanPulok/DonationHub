using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer.Entities
{
    class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Date { get; set; }
        public int OrganisationID { get; set; }

    }
}
