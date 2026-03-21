using Devices.Application.DTOs;
using Devices.Application.services.implementations;
using Devices.Application.services.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devices.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;
        private readonly CloudDinaryService _cloudinary;

        public DeviceController(IDeviceService deviceService, CloudDinaryService cloudinary)
        {
            _deviceService = deviceService;
            _cloudinary = cloudinary;
        }

        [HttpGet]
        public async Task<List<DeviceInformationDTO>> Get()
        {
            return await _deviceService.GetAllDevices();
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task Post([FromForm] DeviceRegisterDto requestDto)
        {
            var url = await _cloudinary.UploadImageAsync(requestDto.Imagen);

            requestDto.ImageURL = url;

            await _deviceService.CreateDevice(requestDto);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
