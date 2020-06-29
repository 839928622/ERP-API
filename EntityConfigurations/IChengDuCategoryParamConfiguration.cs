using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IChengDuCategoryParamConfiguration : IEntityTypeConfiguration<IChengDuCategoryParam>
    {
        public void Configure(EntityTypeBuilder<IChengDuCategoryParam> builder)
        {
          
                builder.ToTable("I_ChengDuCategoryParam");

                builder.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Name).HasMaxLength(100);

                builder.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.UpdateAt).HasColumnType("datetime");

                builder.Property(e => e.Vals).HasColumnType("text");
          
        }
    }
}
