using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UserMicroService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public ActionResult<string> Get()
        {

            string data ="[{\"UserId\":1,\"Name\":\"John\",\"Age\":24,\"email\":\"john.doe @google.com\" }]";
                    return data;
        }
    }
}

