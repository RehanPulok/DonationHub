using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Business_Logic_Layer
{
    class EventService
    {
        EventDataAccess eventDataAccess;
        public EventService()
        {
            this.eventDataAccess = new EventDataAccess();
        }
        public int AddNewEvent(string eventName, string date, int organisationID)
        {
            Event newevent = new Event()

            {
                EventName = eventName,
                Date = date,
                OrganisationID = organisationID
            };
            
            return eventDataAccess.AddEvent(newevent);
        }
        public int DeleteEvent(int id)
        {
            User user = new User() { ID = id };
            return this.eventDataAccess.DeleteEvent(id);
        }
    }
}
