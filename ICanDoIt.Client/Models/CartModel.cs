using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public List<CartItemModel> CartItems { get; set; }
        public double TotalPrice()
        {
            return CartItems.Sum(i=>i.Price*i.Quantity);
        }
    }
    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        [Range(1, 50000, ErrorMessage = "Fiyat 1'den küçük olamaz")]
        public int Quantity { get; set; }
        public int ProductIndex { get; set; }
    }
}
