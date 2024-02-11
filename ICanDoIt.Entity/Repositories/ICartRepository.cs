using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Repositories
{
    public interface ICartRepository: IRepository<Cart>
    {
        Task<Cart> GetByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
        Cart GetByUserId2(string userId);
        void ClearCart(int cartId);
    }
}
