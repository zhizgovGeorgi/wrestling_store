using System;
using System.Collections.Generic;
using System.Text;
using Modules;

namespace DAL
{
    public class MockOrderData : IOrderDataManagement<Order>
    {
        public void AddOrder(Order o)
        {
            List<Order> orders = new List<Order>();
            orders.Add(o);
        }

        public void DeleteOrder(Order order)
        {
            List<Order> orders = new List<Order>();
            orders.Add(order);
            orders.Remove(order);
        }

        public void EditOrder(Order o, Status status)
        {

        }

        public List<Order> GetAllOrders()
        {
            return new List<Order>();
        }

        public List<Order> ShowOrderItems(User user)
        {
            List<Order> orders = new List<Order>();
            Product accessories = new WrestlingAccessories(1, "Nike", "Wrestling Accessories", 120, "www.facebook.bg");
            Order o = new Order(1, user, accessories, "S", 3, Status.Pending);
            orders.Add(o);
            return orders;

        }

        public void UpdateCurrentOrder(Order order, int quantity)
        {
            List<Order> orders = new List<Order>();
            orders.Add(order);
            orders.Remove(order);
        }
    }
}
