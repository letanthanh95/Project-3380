using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.Models
{
    public partial class CustomerManagerment
    {
        //public static int  Customer_Id { get; set; }
        public static string Customer_Id { get; internal set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public string Street_Name { get; set; }
        public int Zip_Code { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
        public object Customer_ID { get; internal set; }
    }
}
