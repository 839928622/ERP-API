using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsModelValueConfiguration : IEntityTypeConfiguration<GoodsModelValue>
    {
        public void Configure(EntityTypeBuilder<GoodsModelValue> builder)
        {
            builder.HasIndex(e => e.GoodsId)
                .HasName("IX_GoodsModelType");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}