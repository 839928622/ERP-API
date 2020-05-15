using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CrawlerRequestConfiguration :IEntityTypeConfiguration<CrawlerRequest>
    {
        public void Configure(EntityTypeBuilder<CrawlerRequest> builder)
        {
            builder.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.CreateAt).HasColumnType("datetime");

            builder.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

            builder.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
           
        }
    }
}
