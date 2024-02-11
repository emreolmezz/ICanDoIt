using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Models
{
    public class SessionCartModel
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public int ProductIndex { get; set; }
    }
}
