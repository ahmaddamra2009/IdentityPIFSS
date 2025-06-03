using Microsoft.AspNetCore.Identity;

namespace IdentityPIFSS.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string? City { get; set; }
        public string? Gender { get; set; }

    }
}
