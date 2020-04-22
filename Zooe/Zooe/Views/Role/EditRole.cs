using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Zooe.Views.Role
{
    //shows the role and the users
    public class EditRole 
    {
        public EditRole()
        {
            //Users = new List<string>();
            Users = new List<IdentityUser>();
            NonUsers = new List<IdentityUser>();
//            AddIds = new List<IdentityUser>();
//            DeleteIds = new List<IdentityUser>();
        }
        
        public IdentityRole Role { get; set; }
        public IEnumerable<IdentityUser> Users { get; set; }
        public IEnumerable<IdentityUser> NonUsers { get; set; }
        
//        public List<IdentityUser> AddIds { get; set; }
//        public List<IdentityUser> DeleteIds { get; set; }

    }
}