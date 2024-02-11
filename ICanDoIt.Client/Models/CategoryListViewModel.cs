using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Models
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        
    }
}
