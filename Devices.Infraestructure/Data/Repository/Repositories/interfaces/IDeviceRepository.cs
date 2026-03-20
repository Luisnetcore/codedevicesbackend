using Devices.Domain.Entities;

namespace Devices.Infraestructure.Data.Repository.Repositories.interfaces
{
    public interface IDeviceRepository
    {
        Task<List<Device>> Search(string? name, Guid? brandId, Guid? categoryId);
    }
}
