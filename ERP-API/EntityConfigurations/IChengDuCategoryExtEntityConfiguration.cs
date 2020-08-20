using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IChengDuCategoryExtEntityConfiguration : IEntityTypeConfiguration<IChengDuCategoryExt>
    {
        public void Configure(EntityTypeBuilder<IChengDuCategoryExt> builder)
        {
           
                builder.ToTable("I_ChengDuCategoryExt");

                builder.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                builder.Property(e => e.Summoney).HasColumnType("money");

                builder.Property(e => e.UpdateAt).HasColumnType("datetime");
            
        }
    }
}
