using Microsoft.AspNetCore.Http;

namespace Devices.Application.DTOs
{
    public class DeviceRegisterDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public IFormFile Imagen { get; set; }
        public string ImageURL { get; set; }
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
    }
}
