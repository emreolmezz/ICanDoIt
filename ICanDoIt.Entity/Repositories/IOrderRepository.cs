using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetUserOrders(string userId);
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
    }
}
