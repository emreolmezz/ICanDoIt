using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Services
{
    public interface ICartService : IService<Cart>
    {
        Task InitializeCart(string userId);
        Task<Cart> GetCartByUserId(string userId);
        Task AddToCart(string userId, int productId, int quantity);
        void DeleteFromCart(string userId, int productId);
        Cart GetCartByUserId2(string userId);
        void ClearCart(int cartId);
    }
}
