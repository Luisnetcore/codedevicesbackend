using Devices.Application.DTOs;
using Devices.Application.services.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devices.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<List<BrandInformationDTO>> Get()
        {
            return await _brandService.GetBrands();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task Post([FromBody] BrandCreateDTO requestDto)
        {
            await _brandService.CreateBrand(requestDto);
        }
    }
}
