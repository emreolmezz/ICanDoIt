using ICanDoIt.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICanDoIt.Data.Seeds
{
    class CargoSeed : IEntityTypeConfiguration<cargoStatus>
    {
        private readonly int[] _ids;
        public CargoSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<cargoStatus> builder)
        {
            builder.HasData(
                new cargoStatus { Id = _ids[0], Status = "Ürününüz Hazırlanıyor."},
                new cargoStatus { Id = _ids[1], Status = "Kargoya Verildi."},
                new cargoStatus { Id = _ids[2], Status = "Teslim Edildi." }
                );
        }
    }
}
