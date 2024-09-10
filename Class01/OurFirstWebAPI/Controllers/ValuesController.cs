using Microsoft.AspNetCore.Mvc;

namespace OurFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController() {}

        [HttpGet]
        [Route("helloWorld")]
        public string HelloWorld()
        {
            return "Hello World from Qinshift Academy";
        }
    }
}
