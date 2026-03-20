using Devices.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Devices.Infraestructure.Data
{
    public class DeviceDBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }

        public DeviceDBContext(DbContextOptions<DeviceDBContext> options)
            : base(options)
        {

        }

    }
}
