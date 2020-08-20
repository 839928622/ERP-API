using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IChengDuParamValueConfiguration: IEntityTypeConfiguration<IChengDuParamValue>
    {
        public void Configure(EntityTypeBuilder<IChengDuParamValue> builder)
        {
            
                builder.ToTable("I_ChengDuParamValue");

                builder.Property(e => e.UpdateAt).HasColumnType("datetime");

                builder.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);
         
        }
    }
}
