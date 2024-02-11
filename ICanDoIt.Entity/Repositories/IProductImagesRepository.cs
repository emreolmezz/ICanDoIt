using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Repositories
{
    public interface IProductImagesRepository : IRepository<ProductImages>
    {
        Task<IList<ProductImages>> GetImagesByProduct(int id);
        void RemoveProductImages(int id);
    }
}
