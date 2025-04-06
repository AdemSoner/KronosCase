using Case.Application.Abstraction;
using Case.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.Persistence
{
    public class OrderService : IOrderService
    {

        public List<Order> getOrders()
        => new()
        {
            new Order { Id=Guid.NewGuid(), Adress="İstanbul", CargoCompany="Yurtiçi", CreatedDate=DateTime.Now.AddHours(-5) , CustomerId=Guid.NewGuid().ToString(), Products=new List<string>{"Araba","Motor"} },
            new Order { Id=Guid.NewGuid(), Adress="Ümraniye", CargoCompany="Mng", CreatedDate=DateTime.Now.AddDays(-1) , CustomerId=Guid.NewGuid().ToString(), Products=new List<string>{"Bilgisayar","Tablet"} },
            new Order { Id=Guid.NewGuid(), Adress="Esenkent", CargoCompany="Aras", CreatedDate=DateTime.Now.AddHours(-10) , CustomerId=Guid.NewGuid().ToString(), Products=new List<string>{"PS","TV"} },
        };

        public List<Order> InsertOrder(OrderDto order)
        {
            var newOrder = new Order 
            {
                Id = Guid.NewGuid(),
                Adress=order.Adress,
                CargoCompany=order.CargoCompany,
                Products=order.Products,
                CreatedDate = DateTime.Now,
                CustomerId = Guid.NewGuid().ToString(),
            };
            var orders = getOrders();
            orders.Add(newOrder);
            return orders;
        }
    }
}
