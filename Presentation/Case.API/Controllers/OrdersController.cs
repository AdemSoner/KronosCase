using Case.Application.Abstraction;
using Case.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService=orderService;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders= _orderService.getOrders();
            if (orders != null)
            {
                return Ok(new ResponseModelDto
                {
                    data = orders,
                    message = "İşlem Başarılı",
                    status = true
                });
            }
            else
            {
                return Ok(new ResponseModelDto
                {
                    message = "İşlem Başarısız",
                    status = false
                });
            };
        }
        [HttpPost]
        public IActionResult InsertOrder(OrderDto order)
        {
            var orders = _orderService.InsertOrder(order);
            if (orders != null)
            {
                return Ok(new ResponseModelDto
                {
                    data = orders,
                    message = "İşlem Başarılı",
                    status = true
                });
            }
            else
            {
                return Ok(new ResponseModelDto
                {
                    message = "İşlem Başarısız",
                    status = false
                });
            }
        }

       
    }
}
