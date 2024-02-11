using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ICanDoIt.Entity.Entities
{
    public class Product
    {
        public Product()
        {
            productImages = new Collection<ProductImages>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public bool isStock { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductImages> productImages { get; set; }
        public DateTime DateAdded { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
