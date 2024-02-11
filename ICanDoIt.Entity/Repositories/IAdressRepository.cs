using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Repositories
{
    public interface IAdressRepository: IRepository<Adresses>
    {
        Task<IEnumerable<Adresses>> GetAdressesByUserId(string Id);
        Task<Adresses> GetAdressById(int id);
    }
}
