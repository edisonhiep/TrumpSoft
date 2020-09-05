using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");
            builder.HasKey(x => x.p_ID);
            builder.HasMany(x => x.Categories);
            builder.HasMany(x => x.products);
            builder.Property(x => x.p_Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}
