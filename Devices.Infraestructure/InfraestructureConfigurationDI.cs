using Devices.Infraestructure.Data.Repository.Repositories;
using Devices.Infraestructure.Data.Repository.Repositories.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Devices.Infraestructure
{
    public static class InfraestructureConfigurationDI
    {
        public static IServiceCollection AddDeviceInfraestructure(this IServiceCollection services)
        {
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
