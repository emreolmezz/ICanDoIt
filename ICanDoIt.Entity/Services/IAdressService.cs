using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoIt.Entity.Services
{
    public interface IAdressService: IService<Adresses>
    {
        Task<IEnumerable<Adresses>> GetAdressesByUserId(string Id);
        Task<Adresses> GetAdressById(int id);
    }
}
