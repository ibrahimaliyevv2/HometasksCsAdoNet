using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace StadiumTask2.Models
{
    public class StadiumData
    {

        public void AddStadium(Stadium stadium)
        {
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=StadiumsDB;User Id=sa;Password=MyPass@word"))
            {
                connection.Open();
                string query = $"INSERT INTO Stadiums (Name, HourlyPrice, Capacity) VALUES ({stadium.Name}, {stadium.HourlyPrice}, {stadium.Capacity})";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public List<Stadium> GetAll()
        {
            List<Stadium> stadiums = new List<Stadium>();
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=StadiumsDB;User Id=sa;Password=MyPass@word"))
            {
                string query = "SELECT * FROM Stadiums";

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Stadium stadium = new Stadium
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            HourlyPrice = dr.GetDecimal(2),
                            Capacity = dr.GetByte(3),
                        };
                        stadiums.Add(stadium);
                    }
                }
            }
            return stadiums;
        }

        public Stadium GetById(int id)
        {
            Stadium stadium = null;
            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=StadiumsDB;User Id=sa;Password=MyPass@word"))
            {
                connection.Open();
                string query = "SELECT * FROM Stadiums WHERE  Id=@id";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        stadium = new Stadium
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            HourlyPrice = dr.GetDecimal(2),
                            Capacity = dr.GetByte(3)
                        };
                    }
                }
            }
            return stadium;

        }


        public void DeleteById(int id)
        {

            using (SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=StadiumsDB;User Id=sa;Password=MyPass@word"))
            {
                connection.Open();
                string query = "DELETE FROM Stadiums WHERE  Id=@id";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
