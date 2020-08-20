using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsPackageConfiguration : IEntityTypeConfiguration<GoodsPackage>
    {
        public void Configure(EntityTypeBuilder<GoodsPackage> builder)
        {
            builder.HasIndex(e => new { e.GoodsId, e.Type })
                .HasName("IX_GoodsPackage")
                .IsUnique();

            builder.Property(e => e.BarCode)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('‘’')");

            builder.Property(e => e.DonvvSkuCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.DonvvSpuCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Price).HasColumnType("money");

            builder.Property(e => e.PriceExtend).HasColumnType("decimal(10, 2)");

            builder.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'小')")
                .HasComment("[小、中、大]");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}