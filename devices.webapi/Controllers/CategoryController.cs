using Devices.Application.DTOs;
using Devices.Application.services.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devices.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<List<CategoryInformationDto>> Get()
        {
            return await _categoryService.GetAllCategories();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<CategoryCreateDto> Post([FromBody] CategoryCreateDto requestDto)
        {
            return await _categoryService.CreateCategory(requestDto);
        }
    }
}
