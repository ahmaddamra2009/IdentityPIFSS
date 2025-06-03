using System.ComponentModel.DataAnnotations;

namespace IdentityPIFSS.Models.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required(ErrorMessage ="Enter Role Name")]
        [MinLength(2)]
        public string RoleName { get; set; }
    }
}
