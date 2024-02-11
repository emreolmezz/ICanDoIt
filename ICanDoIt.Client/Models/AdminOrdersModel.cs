using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Models
{
    public class AdminOrdersModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
