using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
namespace ZooProjF.Models
{
    public class ExhibitContext
    {
        public string ConnectionString { get; set; }

        public ExhibitContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        [HttpPost]
        public List<ExhibitModel> GetAllExhibits()
        {
            List<ExhibitModel> list = new List<ExhibitModel>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Name, Description, Image_URL FROM Exhibit", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ExhibitModel()
                        {
                            //Exhibit_ID = Convert.ToString(reader[0]),
                            //Department_ID = Convert.ToString(reader[1]),
                            //Animal_ID = Convert.ToString(reader[2]),
                            Name = Convert.ToString(reader[0]),
                            //Exhibit_Habitat = Convert.ToString(reader[4]),
                            Description = Convert.ToString(reader[1]),
                            Image_URL = Convert.ToString(reader[2])
                        });
                    }
                }
            }
            return list;
        }
    }
}