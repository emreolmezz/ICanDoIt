using ICanDoIt.Data.Repositories;
using ICanDoIt.Entity.IUnitOfWork;
using ICanDoIt.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;

        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        private CartRepository _cartRepository;
        private OrderRepository _orderRepository;
        private AdressRepository _adressRepository;
        private ProductImagesRepository _productImagesRepository;

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        public ICartRepository Carts => _cartRepository = _cartRepository ?? new CartRepository(_context);
        public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);
        public IAdressRepository Adresses => _adressRepository = _adressRepository ?? new AdressRepository(_context);

        public IProductImagesRepository ProductImages => _productImagesRepository = _productImagesRepository ?? new ProductImagesRepository(_context);

        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
