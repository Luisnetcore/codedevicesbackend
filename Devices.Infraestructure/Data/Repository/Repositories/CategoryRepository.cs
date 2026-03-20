using Devices.Domain.Entities;
using Devices.Infraestructure.Data.Repository.Repositories.interfaces;

namespace Devices.Infraestructure.Data.Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DeviceDBContext context) : base(context)
        {
        }
    }
}
