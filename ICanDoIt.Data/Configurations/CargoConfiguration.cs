using ICanDoIt.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICanDoIt.Data.Configurations
{
    class CargoConfiguration : IEntityTypeConfiguration<cargoStatus>
    {
        public void Configure(EntityTypeBuilder<cargoStatus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("CargoStatus");
        }
    }
}
