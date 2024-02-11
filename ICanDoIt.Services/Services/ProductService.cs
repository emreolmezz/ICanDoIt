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
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public int GetCountByCategory(string category)
        {
            return _unitOfWork.Products.GetCountByCategory(category);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string name, int page, int pageSize)
        {
            return await _unitOfWork.Products.GetProductsByCategory(name, page, pageSize);
        }

        public bool GetProductWithUrl(string productUrl)
        {
            return _unitOfWork.Products.GetProductWithUrl(productUrl);
        }

        public async Task<IEnumerable<Product>> GetSearchResult(string query)
        {
            return await _unitOfWork.Products.GetSearchResult(query);
        }

        public async Task<Product> GetWithCategoryByIdAsync(string url)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(url);
        }
    }
}
