using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public IList<ProductImages> ProductImages { get; set; }
    }
}
