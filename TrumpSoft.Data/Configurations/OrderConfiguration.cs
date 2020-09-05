using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.o_ID);
            builder.Property(x => x.o_Status).IsRequired().HasDefaultValue(OrderStatus.TiepNhan);
            builder.Property(x => x.o_ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}
