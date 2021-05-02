using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class DataAccess
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            try
            {
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DonationHubDb"].ConnectionString);
                this.connection.Open();
            }
            catch (Exception exp)
            {

                throw;
            }     
        }
        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }
        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }
        
        /*
        ~DataAccess()
        {
            this.connection.Close();
        }
        */
        


    }
}
