using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IEfficientGoodsConfiguration : IEntityTypeConfiguration<IEfficientGoods>
    {
        public void Configure(EntityTypeBuilder<IEfficientGoods> builder)
        {

          
                builder.ToTable("I_EfficientGoods");

                builder.Property(e => e.AddAt).HasColumnType("datetime");

                builder.Property(e => e.AddBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.EfficientGoodsCardNum)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.EfficientGoodsCardOrgan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.EfficientGoodsImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                builder.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                builder.Property(e => e.IprojectId).HasColumnName("IProjectId");

                builder.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                builder.Property(e => e.UpdateAt).HasColumnType("datetime");
           
        }
    }
}
