using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;

namespace TrumpSoft.Data.Configurations
{
    public class CategoriesTranslationConfiguration : IEntityTypeConfiguration<CategoriesTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoriesTranslation> builder)
        {
            builder.ToTable("CategoriesTranslations");
            builder.HasKey(x => x.ct_ID);
            builder.HasMany(x => x.categories);
            builder.HasMany(x => x.languages);
            builder.Property(x => x.ct_Name).IsRequired();
        }
    }
}
