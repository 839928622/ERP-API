using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsTypePrivateInfoConfiguration : IEntityTypeConfiguration<GoodsTypePrivateInfo>
    {
        public void Configure(EntityTypeBuilder<GoodsTypePrivateInfo> builder)
        {
            builder.HasIndex(e => new { e.TypeId, e.BranchId })
                .HasName("IX_GoodsTypePrivateInfo")
                .IsUnique();

            builder.Property(e => e.Alias)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Sort).HasDefaultValueSql("((99))");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}