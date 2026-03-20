
using Microsoft.AspNetCore.Identity;

namespace Devices.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
