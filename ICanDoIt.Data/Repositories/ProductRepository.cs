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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ShopContext _shopContext { get => _context as ShopContext; }
        public ProductRepository(ShopContext context) : base(context)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(string url)
        {
            return await _shopContext.Products.Where(i => i.Url == url).Include(i => i.Category).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string name, int page, int pageSize)
        {
            var products = _shopContext.Products.OrderByDescending(i=>i.Id).Where(i =>i.isStock).AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                products = products.Include(i => i.Category).Where(i => i.Category.Url == name.ToLower());
            }
            return await products.Skip((page-1)*pageSize).Take(pageSize).ToListAsync();
        }

        public int GetCountByCategory(string category)
        {
            var products = _shopContext.Products.Where(i => i.isStock).AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                products = products.Include(i => i.Category).Where(i => i.Category.Url == category.ToLower());
            }
            return products.Count();
        }

        public async Task<IEnumerable<Product>> GetSearchResult(string query)
        {
            var products = _shopContext.Products.Where(i => i.isStock).Where(i => i.Name.ToLower().Contains(query.ToLower()) || i.Description.ToLower().Contains(query.ToLower())).AsQueryable();
            return await products.ToListAsync();
        }

        public bool GetProductWithUrl(string productUrl)
        {
            var product = _shopContext.Products.Where(i => i.Url == productUrl).FirstOrDefault();
            if (product != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
