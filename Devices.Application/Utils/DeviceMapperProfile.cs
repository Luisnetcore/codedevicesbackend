using AutoMapper;
using Devices.Application.DTOs;
using Devices.Domain.Entities;

namespace Devices.Application.Utils
{
    public class DeviceMapperProfile : Profile
    {
        public DeviceMapperProfile()
        {
            CreateMap<Device, DeviceInformationDTO>();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<Category, CategoryInformationDto>().ForMember(dest => dest.CategoryId,
                       opt => opt.MapFrom(src => src.Id)).ReverseMap();

            CreateMap<Brand, BrandCreateDTO>().ReverseMap();
            CreateMap<Brand, BrandInformationDTO>().ForMember(dest => dest.BrandId,
                       opt => opt.MapFrom(src => src.Id)).ReverseMap();
        }
    }
}
