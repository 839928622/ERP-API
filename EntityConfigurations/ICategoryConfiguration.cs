using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class ICategoryConfiguration : IEntityTypeConfiguration<ICategory>
    {
        public void Configure(EntityTypeBuilder<ICategory> builder)
        {
            
                builder.ToTable("I_Category");

                builder.Property(e => e.Discount).HasColumnType("decimal(8, 4)");

                builder.Property(e => e.Discount2).HasColumnType("decimal(8, 4)");

                builder.Property(e => e.Discount3).HasColumnType("decimal(8, 4)");

                builder.Property(e => e.Discount4).HasColumnType("decimal(8, 4)");

                builder.Property(e => e.ICategory1)
                    .IsRequired()
                    .HasColumnName("I_Category")
                    .HasMaxLength(100);

                builder.Property(e => e.IPlatId).HasColumnName("I_PlatId");

                builder.Property(e => e.ITypeCode)
                    .IsRequired()
                    .HasColumnName("I_TypeCode")
                    .HasMaxLength(100);

                builder.Property(e => e.ITypeName)
                    .IsRequired()
                    .HasColumnName("I_TypeName")
                    .HasMaxLength(100);

                builder.Property(e => e.UpdateTime).HasColumnType("datetime");
            
        }
    }
}
