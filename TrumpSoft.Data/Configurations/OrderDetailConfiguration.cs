using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Entities;

namespace TrumpSoft.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => new { x.od_OrderID, x.od_ProductID });
            builder.HasOne(x => x.order).WithMany(x => x.orderDetails).HasForeignKey(x => x.od_OrderID);
            builder.HasOne(x => x.product).WithMany(x => x.orderDetails).HasForeignKey(x => x.od_ProductID);
        }
    }
}
