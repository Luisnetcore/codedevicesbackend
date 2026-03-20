using Devices.Application.DTOs;

namespace Devices.Application.services.interfaces
{
    public interface ICategoryService
    {
        public Task<CategoryCreateDto> CreateCategory(CategoryCreateDto categoryCreateDto);
        public Task<List<CategoryInformationDto>> GetAllCategories();
    }
}
