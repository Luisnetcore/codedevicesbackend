using Devices.Domain.Entities;
using Devices.Infraestructure.Data;
using Devices.Infraestructure.Data.Repository;
using Devices.Infraestructure.Data.Repository.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Infraestructure.Data.Repository.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(DeviceDBContext context) : base(context) { }
    }
}
