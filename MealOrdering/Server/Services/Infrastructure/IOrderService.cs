using MealOrdering.Shared.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using MealOrdering.Shared.FilterModels;

namespace MealOrdering.Server.Services.Infrastructure
{
    public interface IOrderService
    {
        public Task<OrderDTO> CreateOrder(OrderDTO Order);

        public Task<OrderDTO> UpdateOrder(OrderDTO Order);

        public Task DeleteOrder(Guid OrderId);

        public Task<List<OrderDTO>> GetOrders(DateTime OrderDate);

        public Task<List<OrderDTO>> GetOrdersByFilter(OrderListFilterModel Filter);

        public Task<OrderDTO> GetOrderById(Guid Id);

        public Task<OrderItemsDTO> CreateOrderItem(OrderItemsDTO OrderItem);

        public Task<OrderItemsDTO> UpdateOrderItem(OrderItemsDTO OrderItem);

        public Task<List<OrderItemsDTO>> GetOrderItems(Guid OrderId);

        public Task<OrderItemsDTO> GetOrderItemsById(Guid Id);

        public Task DeleteOrderItem(Guid OrderItemId);
    }
}
