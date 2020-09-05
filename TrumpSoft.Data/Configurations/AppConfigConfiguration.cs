using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrumpSoft.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrumpSoft.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<Configuration>
    {
        public void Configure(EntityTypeBuilder<Configuration> builder)
        {
            builder.ToTable("Configurations");
            builder.HasKey(x => x.c_Key);
            builder.Property(x => x.c_Value).IsRequired();
        }
    }
}
