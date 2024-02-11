using ICanDoIt.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Models
{
    public class AddAdressModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string UserId { get; set; }
        public Adresses Adresses { get; set; }
    }
}
