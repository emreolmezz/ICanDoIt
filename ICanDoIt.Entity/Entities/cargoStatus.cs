using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ICanDoIt.Entity.Entities
{
    public class cargoStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public cargoStatus()
        {
            Orders = new Collection<Order>();
        }
        public ICollection<Order> Orders { get; set; }
    }
}
