using Devices.Application.DTOs;
using Devices.Application.services.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devices.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // GET: api/<AuthController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost("login")]
        public async Task<object> Login([FromBody] LoginDto loginDto)
        {
            var token = await _authService.Login(loginDto);
            return new {token = token};
        }

        [HttpPost("register")]
        public async Task<string> Register([FromBody] RegisterDto registerDto)
        {
            return await _authService.Register(registerDto);
        }
    }
}
