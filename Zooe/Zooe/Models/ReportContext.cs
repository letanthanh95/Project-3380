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

        public List<ItemPurchase> SubReports(string leftside, string rightside)
        {
            string dateFrom = "\'" + leftside + "\'";
            string dateTo = "\'" + rightside + "\'";

            List<ItemPurchase> list = new List<ItemPurchase>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmdcheck = new MySqlCommand("SELECT count(*) tocheck FROM Item_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);
                MySqlCommand cmd1 = new MySqlCommand("SELECT AVG(Total_Cost) average_Cost FROM Item_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);
                MySqlCommand cmd2 = new MySqlCommand("select count(Transaction_ID) Numof_Sales from Item_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);
                MySqlCommand cmd3 = new MySqlCommand("select sum(Quantity) Count_Sales from Item_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);

                using (var readercheck = cmdcheck.ExecuteReader())
                {
                    while (readercheck.Read())
                    {
                        int check = Convert.ToInt32(readercheck["tocheck"]);
                        if (check == 0)
                        {
                            list.Add(new ItemPurchase());
                            list[0].TransactionId = -1;
                            return list;
                        }
                    }
                }
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
                    while (reader2.Read())
                    {
                        list[0].ItemId = Convert.ToInt32(reader2["Numof_Sales"]);
                    }
                }
                using (var reader3 = cmd3.ExecuteReader())
                {
                    while (reader3.Read())
                    {
                        list[0].CustomerId = Convert.ToInt32(reader3["Count_sales"]);
                    }
                }
                return list;

            }
        }

        public List<TicketPurchase> SubReportsT(string leftside, string rightside)
        {
            string dateFrom = "\'" + leftside + "\'";
            string dateTo = "\'" + rightside + "\'";
            List<TicketPurchase> list = new List<TicketPurchase>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmdcheck = new MySqlCommand("SELECT count(*) tocheck FROM Ticket_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);
                MySqlCommand cmd1 = new MySqlCommand("SELECT AVG(Price) average_Cost FROM Ticket_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);
                MySqlCommand cmd2 = new MySqlCommand("select count(Transaction_ID) Numof_Sales from Ticket_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);
                MySqlCommand cmd3 = new MySqlCommand("select sum(Price) Count_Sales from Ticket_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);

                using (var readercheck = cmdcheck.ExecuteReader())
                {
                    while (readercheck.Read())
                    {
                        int check = Convert.ToInt32(readercheck["tocheck"]);
                        if (check == 0)
                        {
                            list.Add(new TicketPurchase());
                            list[0].TransactionId = -1;
                            return list;
                        }
                    }
                }

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
                    while (reader2.Read())
                    {
                        list[0].CustomerId = Convert.ToInt32(reader2["Numof_Sales"]);
                    }
                }
                using (var reader3 = cmd3.ExecuteReader())
                {
                    while (reader3.Read())
                    {
                        list[0].TicketId = Convert.ToInt32(reader3["Count_sales"]);
                    }
                }
                return list;
            }
        }

        public List<ItemPurchase> GetReports()
        {
            string dateFrom = "2010-10-03";
            dateFrom += " 00:00:01";
            string dateTo = "2030-12-31";
            dateTo += " 23:59:59";
            List<ItemPurchase> list = SubReports(dateFrom, dateTo);
            //list.Add(SubReports());

            dateFrom = "\'" + dateFrom + "\'";
            dateTo = "\'" + dateTo + "\'";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Item_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);

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
        [HttpPost]
        public List<ItemPurchase> GetReports(Team10.ItemPurchase model)
        {
            string dateFrom = model.linput.ToString();
            dateFrom += " 00:00:01";
            string dateTo = model.rinput.ToString();
            dateTo += " 23:59:59";
            List<ItemPurchase> list = SubReports(dateFrom, dateTo);
            //list.Add(SubReports());
            if (list[0].TransactionId == -1)
            {
                return list;
            }
            dateFrom = "\'" + dateFrom + "\'";
            dateTo = "\'" + dateTo + "\'";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Item_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);

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
            string dateFrom = "2010-10-03";
            dateFrom += " 00:00:01";
            string dateTo = "2030-12-31";
            dateTo += " 23:59:59";
            List<TicketPurchase> list = SubReportsT(dateFrom, dateTo);
            //list.Add(SubReports());
            if (list[0].TransactionId == -1)
            {
                return list;
            }
            dateFrom = "\'" + dateFrom + "\'";
            dateTo = "\'" + dateTo + "\'";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Ticket_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);

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

        [HttpPost]
        public List<TicketPurchase> GetReportsT(Team10.TicketPurchase model)
        {
            string dateFrom = model.linput.ToString();
            dateFrom += " 00:00:01";
            string dateTo = model.rinput.ToString();
            dateTo += " 23:59:59";
            List<TicketPurchase> list = SubReportsT(dateFrom, dateTo);
            //list.Add(SubReports());
            dateFrom = "\'" + dateFrom + "\'";
            dateTo = "\'" + dateTo + "\'";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Ticket_Purchase where Purchase_Date BETWEEN " + dateFrom + " AND " + dateTo, conn);

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
