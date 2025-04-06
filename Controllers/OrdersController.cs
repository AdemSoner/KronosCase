using Case.Application.Abstractions;
using Case.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KronosCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = _orderService.GetOrders();
            return Ok(orders);
        }

        [HttpPost]
        public IActionResult Insert(OrderDto data)
        {
            var orders = _orderService.Insert(data);

            if (orders!=null)
                return Ok(new ResponseModelDto
                {
                    Message="Başarılı",
                    Status=true,
                    Response=orders
                });
            else
                return Ok(new ResponseModelDto
                {
                    Message="Bir hata oluştu",
                    Status=false,
                });
        }
    }
}
