using MySql.Data.MySqlClient;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using ZooProjF.Models;


namespace ZooProjF.Data
{
    public class CustomerContextcs
    {
        public string ConnectionString { get; set; }

        public CustomerContextcs(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public void getDataSet()
        {
            // DataSet dataset = new DataSet();
        }

        public List<CustomerManagerment> GetAllCustomer()
        {
            List<CustomerManagerment> list = new List<CustomerManagerment>();
            using (MySqlConnection conn=GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SECLECT * from Customer", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CustomerManagerment()
                        {
                            Customer_ID = Convert.ToInt32(reader["Customer_ID"]),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Phone_Number = Convert.ToInt32(reader["Phone_Number"]),
                            Email = reader["Email"].ToString(),
                            Street_Name = reader["Street_Name"].ToString(),
                            Zip_Code = Convert.ToInt32(reader["Zip_Code"]),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString()
                        });
                    }
                }  
            }
                return list;
            }
        /*public int AddCustomerToDB(CustomerManagerment customer)
        {
            try
            {
                using var context = new DataContext(ConnectionString)
                {

                };
        }*/
    }
}
    
