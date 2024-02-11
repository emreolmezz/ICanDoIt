using ICanDoIt.Entity.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ICanDoIt.Client.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Display(Name = "Name", Prompt = "Enter product name")]
        [Required(ErrorMessage = "Name zorunlu bir alan")]
        [StringLength(60,MinimumLength =1,ErrorMessage ="Ürün 1 ila 60 karakter arasında olmalıdır.")]
        public string Name { get; set; }
        public string Url { get; set; }
        [Required(ErrorMessage = "Price zorunlu bir alan")]
        [Range(1,50000, ErrorMessage ="Fiyat 1'den küçük olamaz")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Description zorunlu bir alan")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Ürün 5 ila 200 karakter arasında olmalıdır.")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Ürüne fotoğraf eklemek zorunludur")]
        public List<ProductImages> productImages { get; set; }
        public bool isStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}