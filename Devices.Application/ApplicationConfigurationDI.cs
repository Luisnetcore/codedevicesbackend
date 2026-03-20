using Devices.Application.services.implementations;
using Devices.Application.services.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Devices.Application
{
    public static class ApplicationConfigurationDI
    {
        public static IServiceCollection AddDeviceApplication(this IServiceCollection services)
        {
            services.AddScoped<IDeviceService, DeviceService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBrandService, BrandService>();

            return services;
        }
    }
}
