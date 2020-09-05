using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;

namespace TrumpSoft.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.p_ID);
            builder.Property(x => x.p_Price).IsRequired();
            builder.Property(x => x.p_OriginalPrice).IsRequired();
            builder.Property(x => x.p_Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.p_ViewCount).IsRequired().HasDefaultValue(0);
        }
    }
}
