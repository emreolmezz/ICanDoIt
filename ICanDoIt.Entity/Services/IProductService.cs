using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(string url);
        Task<IEnumerable<Product>> GetProductsByCategory(string name,int page,int pageSize);
        int GetCountByCategory(string category);
        Task<IEnumerable<Product>> GetSearchResult(string query);
        bool GetProductWithUrl(string productUrl);
    }
}
