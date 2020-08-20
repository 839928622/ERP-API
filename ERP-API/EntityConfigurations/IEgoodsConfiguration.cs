using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IEgoodsConfiguration : IEntityTypeConfiguration<IEgoods>
    {
        public void Configure(EntityTypeBuilder<IEgoods> builder)
        {
           
                builder.ToTable("I_EGoods");

                builder.HasComment("商品环保标志");

                builder.Property(e => e.CertDate).HasColumnType("datetime");

                builder.Property(e => e.CertNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.UpdateAt).HasColumnType("datetime");

                builder.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
           
        }
    }
}
