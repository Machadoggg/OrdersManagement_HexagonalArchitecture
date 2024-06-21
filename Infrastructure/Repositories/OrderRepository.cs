using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();

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
