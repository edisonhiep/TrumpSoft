using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;

namespace TrumpSoft.Data.Configurations
{
    public class ProductInCategoryConfigruration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            builder.ToTable("ProductInCategories");

            builder.HasOne(p => p.product)
            .WithMany(p => p.productInCategories)
            .HasForeignKey(pt => pt.ProductId);

            builder.HasOne(c => c.category)
            .WithMany(t => t.productInCategories)
            .HasForeignKey(pt => pt.CategoryId);
        }
    }
}
