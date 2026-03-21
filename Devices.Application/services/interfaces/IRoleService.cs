using Microsoft.AspNetCore.Identity;

namespace Devices.Application.services.interfaces
{
    public interface IRoleService
    {
        Task SeedRoles(RoleManager<IdentityRole> roleManager);
    }
}
