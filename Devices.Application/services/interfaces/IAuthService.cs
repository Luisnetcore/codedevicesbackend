using Devices.Application.DTOs;

namespace Devices.Application.services.interfaces
{
    public interface IAuthService
    {
        Task<string> Login(LoginDto dto);
        Task<string> Register(RegisterDto dto);
    }
}
