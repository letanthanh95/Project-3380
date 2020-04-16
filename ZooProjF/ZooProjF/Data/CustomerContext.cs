using MySql.Data.MySqlClient;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Data.Linq;
using System.Threading.Tasks;
using ZooProjF.Models;
using System.Configuration;
//using Thunderstruck;
using Ado;
using Microsoft.AspNetCore.Mvc;

namespace ZooProjF.Data
{
    public class CustomerContext
    {
        public string ConnectionString { get; set; }

        public CustomerContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        [HttpPost]
        public void getDataSet()
        {
            // DataSet dataset = new DataSet();
        }

        [HttpPost]
        public List<CustomerManagement> GetAllCustomer()
        {
            List<CustomerManagement> list = new List<CustomerManagement>();
            using (MySqlConnection conn = GetConnection())
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `Customer`", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CustomerManagement()
                        {
                            //Customer_Id = Convert.ToString(reader[0]),
                            //Phone_Number = Convert.ToInt16(reader[]),
                            //Zip_Code = Convert.ToInt64(reader[]),
                            First_Name = Convert.ToString(reader[0]),
                            Last_Name = Convert.ToString(reader[1]),
                            Email = Convert.ToString(reader[2]),
                            Street_Name = Convert.ToString(reader[3]),
                            City = Convert.ToString(reader[4]),
                            State = Convert.ToString(reader[5]),
                        });
                    }
                }
            }
            return list;
        }

        [HttpPost]
        public int AddCustomerToDB(CustomerManagement customer)
        {
            try
            {
                using (var context = new DataContext(ConnectionString))
                {
                    var customerId = context.ExecuteGetIdentity("INSERT INTO Customer(Customer_ID,First_Name,Last_Name,Phone_Number,Email,Street_Name,Zip_Code,City,State,Password) VALUES(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9)",
                        customer.CustomerMangagementId, customer.First_Name, customer.Last_Name, customer.Phone_Number, customer.Email, customer.Street_Name, customer.Zip_Code, customer.City, customer.State, customer.Password);
                    return customerId;
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;

            }
            return -1;
        }
    }
}
    

 