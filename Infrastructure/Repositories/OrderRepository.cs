using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>()
             {
            new Order { Id = 1, ProductName = "Product A", Quantity = 2, Price = 10.99m },
            new Order { Id = 2, ProductName = "Product B", Quantity = 1, Price = 5.99m },
            new Order { Id = 3, ProductName = "Product C", Quantity = 5, Price = 20.00m }
        };

        public Order GetOrderById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
    }
}
