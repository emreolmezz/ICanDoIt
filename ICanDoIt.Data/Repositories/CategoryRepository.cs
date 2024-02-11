using ICanDoIt.Entity.Entities;
using ICanDoIt.Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ShopContext _shopContext { get => _context as ShopContext; }
        public CategoryRepository(ShopContext context) : base(context)
        {
        }
        public async Task<Category> GetWithProductsByIdAsync(int CategoryId)
        {
            return await _shopContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == CategoryId);
        }
    }
}
