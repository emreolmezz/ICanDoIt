using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ICanDoIt.Entity.Entities
{
    public class ProductImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product product { get; set; }
    }
}
