using System;
using System.Collections.Generic;
using System.Text;

namespace Modules
{
    public interface IOrderDataManagement<Order>
    {
        void AddOrder(Order o);

        List<Order> ShowOrderItems(User user);

        List<Order> GetAllOrders();

        void DeleteOrder(Order order);

        void EditOrder(Order o, Status status);

    }
}
