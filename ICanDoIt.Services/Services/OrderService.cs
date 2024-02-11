using ICanDoIt.Entity.Entities;
using ICanDoIt.Entity.IUnitOfWork;
using ICanDoIt.Entity.Repositories;
using ICanDoIt.Entity.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Services.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork, IRepository<Order> repository) : base(unitOfWork, repository)
        {

        }
        public async Task Create(Order entity)
        {
            await _unitOfWork.Orders.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _unitOfWork.Orders.GetAllOrders();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _unitOfWork.Orders.GetOrderById(id);
        }

        public async Task<IEnumerable<Order>> GetUserOrders(string userId)
        {
            return await _unitOfWork.Orders.GetUserOrders(userId);
        }
    }
}
