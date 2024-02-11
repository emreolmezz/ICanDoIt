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
    public class AdressRepository : Repository<Adresses>, IAdressRepository
    {
        private ShopContext _shopContext { get => _context as ShopContext; }
        public AdressRepository(ShopContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Adresses>> GetAdressesByUserId(string Id)
        {
            var adresses = _shopContext.Adresses.Where(x => x.UserId == Id);
            return await adresses.ToListAsync();
        }

        public async Task<Adresses> GetAdressById(int id)
        {
            return await _shopContext.Adresses.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
