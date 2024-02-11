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
    public class CartService : Service<Cart>, ICartService
    {
        public CartService(IUnitOfWork unitOfWork, IRepository<Cart> repository) : base(unitOfWork, repository)
        {
        }

        public async Task AddToCart(string userId, int productId, int quantity)
        {
            var cart = await GetCartByUserId(userId);
            if (cart != null)
            {
                //güncelleme
                var index = cart.CartItems.FindIndex(i => i.ProductId == productId);
                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity += quantity;
                }
                _unitOfWork.Carts.Update(cart);
                _unitOfWork.Commit();
                //ekleme
            }
        }

        public void ClearCart(int cartId)
        {
            _unitOfWork.Carts.ClearCart(cartId);
        }

        public  void DeleteFromCart(string userId, int productId)
        {
            var cart =  GetCartByUserId2(userId);
            if (cart != null)
            {
                _unitOfWork.Carts.DeleteFromCart(cart.Id, productId);
            }
        }

        public async Task<Cart> GetCartByUserId(string userId)
        {
            return await _unitOfWork.Carts.GetByUserId(userId);
        }

        public Cart GetCartByUserId2(string userId)
        {
            return _unitOfWork.Carts.GetByUserId2(userId);
        }

        public async Task InitializeCart(string userId)
        {
            var entity = new Cart()
            {
                UserId = userId
            };
            await _unitOfWork.Carts.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
