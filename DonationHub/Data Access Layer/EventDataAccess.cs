using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class EventDataAccess: DataAccess
    {
        public int AddEvent(Event newevent)
        {
            
            string sql = "INSERT INTO Events (EventName, Date,OrganisationID) VALUES ('" + newevent.EventName + "','" + newevent.Date + "','"+newevent.OrganisationID+"')";
            return this.ExecuteQuery(sql);
        }
        public int DeleteEvent(int id)
        {
            string sql = "DELETE FROM Events WHERE EventID=" + id;
            return this.ExecuteQuery(sql);
        }
    }
}
