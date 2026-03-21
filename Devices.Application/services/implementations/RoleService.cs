using Devices.Application.services.interfaces;
using Microsoft.AspNetCore.Identity;

namespace Devices.Application.services.implementations
{
    public class RoleService : IRoleService
    {
        public async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Customer" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }
}
