using ICanDoIt.Entity.Entities;
using ICanDoIt.Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private ShopContext _shopContext { get => _context as ShopContext; }
        public OrderRepository(ShopContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> GetUserOrders(string userId)
        {
            var orders = _shopContext.Orders
                                     .Where(i => i.UserId == userId)
                                     .Include(i => i.OrderItems)
                                     .ThenInclude(i => i.Product).OrderByDescending(i => i.Id);
            return await orders.ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            var orders = _shopContext.Orders
                                     .Include(i => i.OrderItems)
                                     .ThenInclude(i => i.Product);
            return await orders.ToListAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            var order = _shopContext.Orders.Where(i => i.Id == id).Include(i => i.OrderItems).ThenInclude(i => i.Product).FirstOrDefaultAsync();
            return await order;
        }
    }
}
