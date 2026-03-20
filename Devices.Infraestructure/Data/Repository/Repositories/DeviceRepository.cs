using Devices.Domain.Entities;
using Devices.Infraestructure.Data.Repository.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Devices.Infraestructure.Data.Repository.Repositories
{
    public class DeviceRepository : Repository<Device>, IDeviceRepository
    {
        public DeviceRepository(DeviceDBContext context) : base(context)
        {
        }

        public async Task<List<Device>> Search(string? name, Guid? brandId, Guid? categoryId)
        {
            var query = _context.Devices
           .Include(d => d.Brand)
           .Include(d => d.Category)
           .AsQueryable();

            if (!string.IsNullOrEmpty(name))
                query = query.Where(device => device.Name.Contains(name));

            if (brandId.HasValue)
                query = query.Where(d => d.BrandId == brandId);

            if (categoryId.HasValue)
                query = query.Where(d => d.CategoryId == categoryId);

            return await query.ToListAsync();
        }
    }
}
