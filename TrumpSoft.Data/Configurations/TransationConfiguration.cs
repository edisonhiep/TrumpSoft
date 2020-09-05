using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Configurations
{
    public class TransationConfiguration : IEntityTypeConfiguration<Transation>
    {
        public void Configure(EntityTypeBuilder<Transation> builder)
        {
            builder.ToTable("Transations");
            builder.HasKey(x => x.t_ID);
            builder.Property(x => x.t_Status).IsRequired().HasDefaultValue(TransationStatus.Success);
        }
    }
}
