namespace Devices.Domain.Entities
{
    public class Device
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }

        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
