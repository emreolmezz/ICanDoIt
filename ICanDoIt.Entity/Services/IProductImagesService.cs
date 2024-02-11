using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Services
{
    public interface IProductImagesService : IService<ProductImages>
    {
        Task<IList<ProductImages>> GetImagesByProductId(int id);
        void RemoveProductImages(int id);
    }
}
