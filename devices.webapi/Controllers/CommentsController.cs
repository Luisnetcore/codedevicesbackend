using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace devices.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        [HttpGet]
        public Task<List<string>> Get()
        {
            // Placeholder: return an empty list for now
            return Task.FromResult(new List<string>());
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public Task Post([FromBody] string comment)
        {
            // Placeholder: implementation to create a comment will be added later
            return Task.CompletedTask;
        }
    }
}
