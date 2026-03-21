using Devices.Application.DTOs;

namespace Devices.Application.services.interfaces
{
    public interface IDeviceService
    {
        Task<List<DeviceInformationDTO>> GetAllDevices();
        Task<DeviceInformationDTO> CreateDevice(DeviceRegisterDto requestDto);
    }
}
