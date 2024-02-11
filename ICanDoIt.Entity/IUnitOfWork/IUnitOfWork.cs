using ICanDoIt.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }
        ICartRepository Carts { get; }
        IAdressRepository Adresses { get; }
        IProductImagesRepository ProductImages { get; }
        Task CommitAsync();

        void Commit();
    }
}
