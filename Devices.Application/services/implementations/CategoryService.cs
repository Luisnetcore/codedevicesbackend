using AutoMapper;
using Devices.Application.DTOs;
using Devices.Application.services.interfaces;
using Devices.Domain.Entities;
using Devices.Infraestructure.Data.Repository.Repositories.interfaces;

namespace Devices.Application.services.implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _repository = categoryRepository;
            _mapper = mapper;

        }
        public async Task<CategoryCreateDto> CreateCategory(CategoryCreateDto categoryCreateDto)
        {
            var categoryNew = _mapper.Map<Category>(categoryCreateDto);

            await _repository.Add(categoryNew);

            return categoryCreateDto;
        }

        public async Task<List<CategoryInformationDto>> GetAllCategories()
        {
            var categories = await _repository.GetAll();
            var cateriesInformation = _mapper.Map<List<CategoryInformationDto>>(categories);

            return cateriesInformation;
        }
    }
}
