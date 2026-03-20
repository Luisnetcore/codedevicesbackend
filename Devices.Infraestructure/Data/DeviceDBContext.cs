using Devices.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devices.Infraestructure.Data
{
    public class DeviceDBContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DeviceDBContext(DbContextOptions<DeviceDBContext> options)
            : base(options)
        {

        }

    }
}
