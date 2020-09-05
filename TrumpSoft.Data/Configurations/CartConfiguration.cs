using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;

namespace TrumpSoft.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.c_ID);
            builder.HasMany(x => x.products);
            builder.Property(x => x.c_Quantity).IsRequired().HasDefaultValue(1);
            builder.Property(x => x.c_Price).IsRequired();
        }
    }
}
