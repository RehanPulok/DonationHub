using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Data_Access_Layer
{
    class DonorDataAccess:DataAccess
    {
        public List<Donor> GetDonors()
        {
            string sql = "SELECT * FROM Donors";
            SqlDataReader reader = this.GetData(sql);
            List<Donor> donors = new List<Donor>();

            while (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorID = Convert.ToInt32(reader["DonorID"]);
                donor.FirstName = reader["FirstName"].ToString();
                donor.Lastname = reader["LastName"].ToString();
                donor.Email = reader["Email"].ToString();
                donor.Username = reader["Username"].ToString();
                donor.Password = reader["Password"].ToString();
                donor.Gender = reader["Gender"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();


                donors.Add(donor);

            }
            return donors;

        }

        

        public Donor GetDonor(int donorID)
        {
            string sql = "SELECT * FROM Donors WHERE DonorID = " + donorID ;
            SqlDataReader reader = this.GetData(sql);
            List<Donor> donors = new List<Donor>();

            if (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorID = Convert.ToInt32(reader["DonorID"]);
                donor.FirstName = reader["FirstName"].ToString();
                donor.Lastname = reader["LastName"].ToString();
                donor.Email = reader["Email"].ToString();
                donor.Username = reader["Username"].ToString();
                donor.Password = reader["Password"].ToString();
                donor.Gender = reader["Gender"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                return donor;

            }
            
            return null;

        }
        public Donor GetDonorName(int donorID)
        {
            string sql = "SELECT * FROM Users WHERE DonorID = " + donorID;
            SqlDataReader reader = this.GetData(sql);
            List<Donor> donors = new List<Donor>();

            if (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorID = Convert.ToInt32(reader["DonorID"]);
                donor.FirstName = reader["FirstName"].ToString();
                donor.Lastname = reader["LastName"].ToString();
                donor.Email = reader["Email"].ToString();
                donor.Username = reader["Username"].ToString();
                donor.Password = reader["Password"].ToString();
                donor.Gender = reader["Gender"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                return donor;

            }

            return null;

        }


        public int UpdateDonor(Donor donor)
        {
            string sql = "INSERT INTO Donors (FirstName, Lastname,Email, Username, Password, Gender,BloodGroup) VALUES ('" + donor.FirstName + "','" + donor.Lastname + "','" + donor.Email + "''" + donor.Username + "','" + donor.Password + "','" + donor.Gender + "','" + donor.BloodGroup + "')";
            return this.ExecuteQuery(sql);
        }
        public int DeleteDonor(int donorID)
        {
            string sql = "DELETE FROM Donors WHERE DonorID=" + donorID;
            return this.ExecuteQuery(sql);
        }
    }
}
