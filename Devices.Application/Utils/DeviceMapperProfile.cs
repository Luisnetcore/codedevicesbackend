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
        }
    }
}
