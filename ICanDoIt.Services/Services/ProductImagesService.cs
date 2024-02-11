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
    public class ProductImagesService : Service<ProductImages>, IProductImagesService
    {
        public ProductImagesService(IUnitOfWork unitOfWork, IRepository<ProductImages> repository) : base(unitOfWork, repository)
        {
        }
        public async Task<IList<ProductImages>> GetImagesByProductId(int id)
        {
            return await _unitOfWork.ProductImages.GetImagesByProduct(id);
        }

        public void RemoveProductImages(int id)
        {
            _unitOfWork.ProductImages.RemoveProductImages(id);
            _unitOfWork.Commit();
        }
    }
}
