﻿using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsModelConfiguration : IEntityTypeConfiguration<GoodsModel>
    {
        public void Configure(EntityTypeBuilder<GoodsModel> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}