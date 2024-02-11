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
    public class CartRepository: Repository<Cart>, ICartRepository
    {
        private ShopContext _shopContext { get => _context as ShopContext; }
        public CartRepository(ShopContext context) : base(context)
        {
        }

        public async Task<Cart> GetByUserId(string userId)
        {
            return await _shopContext.Carts.Include(i => i.CartItems).ThenInclude(i => i.Product).FirstOrDefaultAsync(i => i.UserId == userId);
        }
        public override Cart Update(Cart entity)
        {
            _shopContext.Carts.Update(entity);
            return entity;
            
        }

        public void DeleteFromCart(int cartId, int productId)
        {            
             var cmd = @"delete from CartItems where CartId=@p0 and ProductId=@p1";
             _shopContext.Database.ExecuteSqlRawAsync(cmd, cartId, productId);      
        }

        public Cart GetByUserId2(string userId)
        {
            
                
           return _shopContext.Carts
                            .Include(i => i.CartItems)
                            .ThenInclude(i => i.Product)
                            .FirstOrDefault(i => i.UserId == userId);
                
            
        }

        public void ClearCart(int cartId)
        {
            var cmd = @"delete from CartItems where CartId=@p0";
            _shopContext.Database.ExecuteSqlRawAsync(cmd, cartId);
        }
    }
}
