using System.ComponentModel.DataAnnotations;

namespace Zooe.Views.Role
{
    //change that will be done to the role
    public class ModifyRole
    {
        [Required]
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] AddIds { get; set; }
        public string[] DeleteIds { get; set; }
    }
}