using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Display(Name = "Name", Prompt = "Category product name")]
        [Required(ErrorMessage = "Name zorunlu bir alan")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Kategori 1 ila 30 karakter arasında olmalıdır.")]
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
