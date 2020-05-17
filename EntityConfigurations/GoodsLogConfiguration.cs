using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsLogConfiguration : IEntityTypeConfiguration<GoodsLog>
    {
        public void Configure(EntityTypeBuilder<GoodsLog> builder)
        {
            builder.HasIndex(e => e.CreatorUserId)
                .HasName("Index_CreatorUserId");

            builder.HasIndex(e => e.GoodsId)
                .HasName("Index_GoodsId");

            builder.HasIndex(e => e.GoodsName)
                .HasName("Index_GoodsName");

            builder.HasIndex(e => e.UserName)
                .HasName("Index_UserName");

            builder.Property(e => e.CreationTime).HasColumnType("datetime");

            builder.Property(e => e.GoodsName)
                .IsRequired()
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.Remark).HasMaxLength(200);

            builder.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
        }
    }
}