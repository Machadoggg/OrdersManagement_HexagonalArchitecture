using Application.Services;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id) 
        {
            var order = _orderService.GetOrder(id);

            return Ok(order);
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            _orderService.CreateOrder(order);


            // Build URI
            var uri = Url.Action("GetOrder", new { id = order.Id });
            return Created(uri, order);
;
        }
    }
}
