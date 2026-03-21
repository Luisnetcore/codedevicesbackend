using AutoMapper;
using Devices.Application.DTOs;
using Devices.Application.services.interfaces;
using Devices.Domain.Entities;
using Devices.Infraestructure.Data.Repository.Repositories.interfaces;

namespace Devices.Application.services.implementations
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _repository;
        private readonly IMapper _mapper;
        public DeviceService(IDeviceRepository deviceRepository, IMapper mapper)
        {
            _repository = deviceRepository;
            _mapper = mapper;
        }

        public async Task<DeviceInformationDTO> CreateDevice(DeviceRegisterDto requestDto)
        {
            var device = _mapper.Map<Device>(requestDto);

            await _repository.Add(device);

            return new DeviceInformationDTO
            {
                Name = device.Name,
                ImageURL = device.ImageURL,
                Price = device.Price,
            };
        }

        public async Task<List<DeviceInformationDTO>> GetAllDevices()
        {
            var listDevices = await _repository.GetAll();

            var listDevicesDtos = _mapper.Map<List<DeviceInformationDTO>>(listDevices);

            //listDevices.ForEach(d =>
            //{
            //    var deviceNew = new DeviceInformationDTO
            //    {
            //        Name = d.Name,
            //        ImageURL = d.ImageURL,
            //        Price = d.Price
            //    };

            //    listDevicesDtos.Add(deviceNew);
            //});

            return listDevicesDtos;
        }
    }
}
