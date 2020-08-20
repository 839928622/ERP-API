using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IBeiJingProductParamConfiguration : IEntityTypeConfiguration<IBeiJingProductParam>
    {
        public void Configure(EntityTypeBuilder<IBeiJingProductParam> builder)
        {
           
                builder.ToTable("I_BeiJingProductParam");

                builder.Property(e => e.IParamName)
                    .HasColumnName("I_ParamName")
                    .HasMaxLength(255);

                builder.Property(e => e.IParamValue)
                    .HasColumnName("I_ParamValue")
                    .HasColumnType("text");

                builder.Property(e => e.IProductId)
                    .HasColumnName("I_ProductId")
                    .HasMaxLength(255);

                builder.Property(e => e.TlspPk)
                    .HasColumnName("TLSP_PK")
                    .HasMaxLength(255);

                builder.Property(e => e.TppvPk)
                    .HasColumnName("TPPV_PK")
                    .HasMaxLength(255);
           
        }
    }
}
