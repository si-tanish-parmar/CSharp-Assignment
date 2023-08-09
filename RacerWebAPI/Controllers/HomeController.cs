using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RacerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Welcome()
        {
            return "Welcome WEB API";
        }
        [HttpGet("display")]
        public string Display()
        {
            return "Hello";
        }
    }

}
