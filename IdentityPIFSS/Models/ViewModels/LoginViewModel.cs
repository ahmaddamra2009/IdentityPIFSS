using System.ComponentModel.DataAnnotations;

namespace IdentityPIFSS.Models.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Enter Email Address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
