using Restoraunt.Domain.Entities.Order;
using System;
using System.Collections.Generic;

namespace Restoraunt.BusinessLogic.Interfaces
{
    public interface IOrder
    {
        List<OrderDTO> GetAllOrders();
        OrderDTO GetOrderById(int id);
        bool CreateOrder(OrderDTO newOrder);
        bool DeleteOrder(int id);
        bool ChangeOrderState(int orderId, Restoraunt.Domain.Enums.Order.UState newState);
        List<OrderDTO> GetOrdersByDate(DateTime startDate, DateTime endDate);
    }
}
