using AutoMapper;
using Devices.Application.DTOs;
using Devices.Domain.Entities;

namespace Devices.Application.Utils
{
    public class DeviceMapperProfile : Profile
    {
        public DeviceMapperProfile()
        {
            CreateMap<DeviceRegisterDto, Device>()
      .ForMember(dest => dest.CategoryId,
          opt => opt.MapFrom(src => Guid.Parse(src.CategoryId)))
      .ForMember(dest => dest.BrandId,
          opt => opt.MapFrom(src => Guid.Parse(src.BrandId)));

            CreateMap<Device, DeviceRegisterDto>()
                .ForMember(dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.CategoryId.ToString()))
                .ForMember(dest => dest.BrandId,
                    opt => opt.MapFrom(src => src.BrandId.ToString()));

            CreateMap<Device, DeviceInformationDTO>();
            CreateMap<DeviceRegisterDto, Device>().ReverseMap();

            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<Category, CategoryInformationDto>().ForMember(dest => dest.CategoryId,
                       opt => opt.MapFrom(src => src.Id)).ReverseMap();

            CreateMap<Brand, BrandCreateDTO>().ReverseMap();
            CreateMap<Brand, BrandInformationDTO>().ForMember(dest => dest.BrandId,
                       opt => opt.MapFrom(src => src.Id)).ReverseMap();
        }
    }
}
