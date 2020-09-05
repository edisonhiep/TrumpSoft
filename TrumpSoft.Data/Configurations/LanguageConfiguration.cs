using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(x => x.l_ID);
            builder.Property(x => x.l_Name).IsRequired();
            builder.Property(x => x.l_IsDefault).IsRequired().HasDefaultValue(LanguageStatus.VietNam);
        }
    }
}
