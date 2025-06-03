using System.ComponentModel.DataAnnotations;

namespace IdentityPIFSS.Models.ViewModels
{
    public class EditRoleViewModel
    {
        [Required]
        public string RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
