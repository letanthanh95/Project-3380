using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Zooe.Team10;

namespace Zooe.Models
{
    public class ReportContext
    {
        private readonly object Team10Context;

        public string ConnectionString { get; set; }
        public ReportContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        [HttpGet("{firstName}/{lastName}/{address}")]

        public string GetQuery(string id, string firstName, string lastName, string address)
        {
            return $"{firstName}:{lastName}:{address}";
        }

        public List<ItemPurchase> SubReports()
        {
            string dateFrom = "2019-10-03";
            string dateTo = "2020-12-31";
            List<ItemPurchase> list = new List<ItemPurchase>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT AVG(Total_Cost) average_Cost FROM Item_Purchase where Purchase_Date >= " + dateFrom, conn);
                MySqlCommand cmd2 = new MySqlCommand("select count(Transaction_ID) Numof_Sales from Item_Purchase where Purchase_Date >= " + dateFrom, conn);
                MySqlCommand cmd3 = new MySqlCommand("select sum(Quantity) Count_Sales from Item_Purchase where Purchase_Date >= " + dateFrom, conn);

                using (var reader1 = cmd1.ExecuteReader())
                {

                    while (reader1.Read())
                    {
                        list.Add(new ItemPurchase
                        {
                            TransactionId = Convert.ToInt32(reader1["Average_Cost"]),
                        });


                    }

                }
                using (var reader2 = cmd2.ExecuteReader())
                {
                    while (reader2.Read()) {
                        list[0].ItemId = Convert.ToInt32(reader2["Numof_Sales"]);
                    }
                }
                using (var reader3 = cmd3.ExecuteReader())
                {
                    while (reader3.Read()){ 
                    list[0].CustomerId = Convert.ToInt32(reader3["Count_sales"]);
                    }
                }
                return list;
            }
        }

        public List<TicketPurchase> SubReportsT()
        {
            string dateFrom = "2019-10-03";
            string dateTo = "2020-12-31";
            List<TicketPurchase> list = new List<TicketPurchase>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT AVG(Price) average_Cost FROM Ticket_Purchase where Purchase_Date >= " + dateFrom, conn);
                MySqlCommand cmd2 = new MySqlCommand("select count(Transaction_ID) Numof_Sales from Ticket_Purchase where Purchase_Date >= " + dateFrom, conn);
                MySqlCommand cmd3 = new MySqlCommand("select sum(Price) Count_Sales from Ticket_Purchase where Purchase_Date >= " + dateFrom, conn);

                using (var reader1 = cmd1.ExecuteReader())
                {

                    while (reader1.Read())
                    {
                        list.Add(new TicketPurchase
                        {
                            TransactionId = Convert.ToInt32(reader1["Average_Cost"]),
                        });


                    }

                }
                using (var reader2 = cmd2.ExecuteReader())
                {
                    while (reader2.Read()) {
                        list[0].CustomerId = Convert.ToInt32(reader2["Numof_Sales"]);
                    }
                }
                using (var reader3 = cmd3.ExecuteReader())
                {
                    while (reader3.Read()){ 
                    list[0].TicketId = Convert.ToInt32(reader3["Count_sales"]);
                    }
                }
                return list;
            }
        }

        public List<ItemPurchase> GetReports()
        {
            string dateFrom = "2019-10-03";
            string dateTo = "2020-12-31";
            List<ItemPurchase> list = SubReports();
            //list.Add(SubReports());
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Item_Purchase where Purchase_Date >= " + dateFrom, conn);
               
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ItemPurchase
                        {
                            TransactionId = Convert.ToInt32(reader["Transaction_Id"]),
                            ItemId = Convert.ToInt32(reader["Item_Id"]),
                            CustomerId = Convert.ToInt32(reader["Customer_Id"]),
                            TotalCost = (float)reader["Total_Cost"],
                            PurchaseDate = Convert.ToDateTime(reader["Purchase_Date"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                        });

                    }
                    return list;
                }

            }

        }

        public List<TicketPurchase> GetReportsT()
        {
            string dateFrom = "2019-10-03";
            string dateTo = "2020-12-31";
            List<TicketPurchase> list = SubReportsT();
            //list.Add(SubReports());
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Ticket_Purchase where Purchase_Date >= " + dateFrom, conn);
               
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TicketPurchase
                        {
                            TransactionId = Convert.ToInt32(reader["Transaction_Id"]),
                            CustomerId = Convert.ToInt32(reader["Customer_Id"]),
                            TicketId = Convert.ToInt32(reader["Ticket_Id"]),
                            Price = (float)reader["Price"],
                            ExpirationDate = Convert.ToDateTime(reader["Expiration_Date"]),
                            PurchaseDate = Convert.ToDateTime(reader["Purchase_Date"]),
                        });

                    }
                    return list;
                }

            }

        }

    }
}
