using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IBeiJingZhengCaiCityListConfiguration : IEntityTypeConfiguration<IBeiJingZhengCaiCityList>
    {
        public void Configure(EntityTypeBuilder<IBeiJingZhengCaiCityList> builder)
        {


                builder.ToTable("I_BeiJingZhengCaiCityList");

                builder.Property(e => e.Code).HasMaxLength(255);

                builder.Property(e => e.Memo).HasMaxLength(255);

                builder.Property(e => e.Name).HasMaxLength(255);

                builder.Property(e => e.Parent).HasMaxLength(255);

                builder.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            
        }
    }
}
