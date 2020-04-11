using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.ViewModels
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z)-9-]+\.[a-zA-Z0-9-.]+$")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confrim password")]
        [Compare("Password",ErrorMessage ="Password and confrimation password do not match")]
        public string ConfirmPassword { get; set; }
        public string First_name { get; internal set; }
        public string Last_Name { get; internal set; }
        public int Phone_Number { get; internal set; }
        public string Street_Name { get; internal set; }
        public int Zip_Code { get; internal set; }
        public string City { get; internal set; }
        public string State { get; internal set; }
        public object Customer_ID { get; internal set; }
    }
}
