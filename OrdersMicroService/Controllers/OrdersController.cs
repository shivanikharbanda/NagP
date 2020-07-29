using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrdersMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {

            string data = "[{\"orders\":[{\"orderId\":1,\"orderAmount\":250,\"orderDate\":\"14-Apr-2020\"},{\"orderId\":2,\"orderAmount\":450,\"orderDate\":\"15-Apr-2020\"}] }]";
            return data;
        }
    }
}
