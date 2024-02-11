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
    public class AdressService : Service<Adresses>, IAdressService
    {
        public AdressService(IUnitOfWork unitOfWork, IRepository<Adresses> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Adresses> GetAdressById(int id)
        {
            return await _unitOfWork.Adresses.GetAdressById(id);
        }

        public async Task<IEnumerable<Adresses>> GetAdressesByUserId(string Id)
        {
            return await _unitOfWork.Adresses.GetAdressesByUserId(Id);
        }
    }
}
