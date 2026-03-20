namespace Devices.Domain.Entities
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Device>? Devices { get; set; }
    }
}
