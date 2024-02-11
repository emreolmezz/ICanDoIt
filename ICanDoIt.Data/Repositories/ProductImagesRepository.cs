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
    public class ProductImagesRepository : Repository<ProductImages>, IProductImagesRepository
    {
        private ShopContext _shopContext { get => _context as ShopContext; }
        public ProductImagesRepository(ShopContext context) : base(context)
        {
        }

        public async Task<IList<ProductImages>> GetImagesByProduct(int id)
        {
            var images = _shopContext.productImages.AsQueryable();
            if (id != null)
            {
                images = images.Include(i => i.product).Where(i => i.product.Id == id);
            }
            var ses = images.ToListAsync();
            return await ses;
        }

        public void RemoveProductImages(int id)
        {
            var images = _shopContext.productImages.AsQueryable();
            foreach (var item in images)
            {
                if (item.ProductId == id)
                {
                    _context.Set<ProductImages>().Remove(item);
                }
            }
        }
    }
}
