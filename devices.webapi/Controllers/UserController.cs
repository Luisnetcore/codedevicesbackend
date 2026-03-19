using Microsoft.AspNetCore.Mvc;

namespace devices.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            //conetca
            return "hola mundo";
        }
    }
}
