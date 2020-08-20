using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IErrLogConfiguration : IEntityTypeConfiguration<IErrLog>
    {
        public void Configure(EntityTypeBuilder<IErrLog> builder)
        {
            
                builder.ToTable("I_ErrLog");

                builder.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(500);

                builder.Property(e => e.JsonStr)
                    .IsRequired()
                    .HasMaxLength(500);

                builder.Property(e => e.UpdateTime).HasColumnType("datetime");
            
        }
    }
}
