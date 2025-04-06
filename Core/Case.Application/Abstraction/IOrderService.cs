using Case.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.Application.Abstraction
{
    public interface IOrderService
    {
        List<Order> getOrders();
        List<Order> InsertOrder(OrderDto order);
    }
}
