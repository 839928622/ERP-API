using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IGoodsConfiguration : IEntityTypeConfiguration<IGoods>
    {
        public void Configure(EntityTypeBuilder<IGoods> builder)
        {
                builder.ToTable("I_Goods");

                builder.HasIndex(e => new { e.GoodsId, e.Unit, e.IProjectId })
                    .HasName("IX_I_Goods")
                    .IsUnique();

                builder.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                builder.Property(e => e.IProjectId).HasColumnName("I_ProjectId");

                builder.Property(e => e.MarketPrice).HasColumnType("money");

                builder.Property(e => e.Price).HasColumnType("money");

                builder.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UpdateTime).HasColumnType("datetime");
           
        }
    }
}
