using Devices.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Application.services.interfaces
{
    public interface IBrandService
    {
        Task<BrandCreateDTO> CreateBrand(BrandCreateDTO brandCreateDTO);
        Task<List<BrandInformationDTO>> GetBrands();
    }
}
