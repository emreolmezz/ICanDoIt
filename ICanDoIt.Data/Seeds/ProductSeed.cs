using ICanDoIt.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICanDoIt.Data.Seeds
{
    public class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Gümüş Kolye", Price = 75, CategoryId=_ids[0], Description= "Paslanmayan Gümüş kolye", isStock=true,ImageUrl="1.jpg",Url="gumus-kolye" },
                new Product { Id = 2, Name = "Pırlanta Kolye", Price = 50, CategoryId = _ids[0], Description = "Paslanmayan Pırlanta kolye", isStock = true, ImageUrl = "2.jpg", Url = "pirlanta-kolye" },
                new Product { Id = 3, Name = "Zümrüt Kolye", Price = 100, CategoryId = _ids[0], Description = "Paslanmayan Zümrüt kolye", isStock = true, ImageUrl = "3.jpg", Url = "zumrut-kolye" },
                new Product { Id = 4, Name = "Bakır Kolye", Price = 5100, CategoryId = _ids[0], Description = "Paslanmayan Bakır kolye", isStock = false, ImageUrl = "4.jpg", Url = "bakir-kolye" },
                new Product { Id = 5, Name = "Altın Küpe", Price = 250, CategoryId = _ids[1], Description = "Yüksek kalite altın küpe", isStock = true, ImageUrl = "5.jpg", Url = "altin-kupe" },
                new Product { Id = 6, Name = "Gümüş Küpe", Price = 750, CategoryId = _ids[1], Description = "Yüksek kalite Gümüş küpe", isStock = false, ImageUrl = "6.jpg", Url = "gumus-küpe" },
                new Product { Id = 7, Name = "Zümrüt Küpe", Price = 500, CategoryId = _ids[1], Description = "Yüksek kalite Zümrüt küpe", isStock=true,ImageUrl="7.jpg",Url="zumrut-kupe" }

                );
        }
    }
}
