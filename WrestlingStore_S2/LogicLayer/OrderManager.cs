using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class OrderManager
    {
        private List<Order> orderItems;
        IOrderDataManagement<Order> orderDataManagement;

        public OrderManager(IOrderDataManagement<Order> orderDataManagement)
        {
            this.orderDataManagement = orderDataManagement;
            orderItems = this.orderDataManagement.GetAllOrders();
        }

        public void AddOrder(Order o)
        {
            orderDataManagement.AddOrder(o);
            orderItems.Add(o);
        }

        public void RemoveCartItem(int orderId)
        {
            Order order = GetOrder(orderId);
            orderDataManagement.DeleteOrder(order);
            orderItems.Remove(order);
        }

        public List<Order> ShowOrderItems(User user)
        {
            List<Order> orders = new List<Order>();
            foreach (Order order in orderDataManagement.ShowOrderItems(user))
            {
                orders.Add(order);
            }
            return orders;
        }

        public List<Order> GetCartItems()
        {
            return orderItems;
        }

        public Order GetOrder(int id)
        {
            return orderItems.Find(x => x.OrderId == id);
        }


        public void EditOrder(Order o, Status status)
        {
            orderDataManagement.EditOrder(o, status);
        }
    }
    
}
