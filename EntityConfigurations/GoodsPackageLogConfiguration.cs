using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsPackageLogConfiguration : IEntityTypeConfiguration<GoodsPackageLog>
    {
        public void Configure(EntityTypeBuilder<GoodsPackageLog> builder)
        {
            builder.Property(e => e.BarCode)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.OldBarCode)
                .HasMaxLength(10)
                .IsFixedLength();

            builder.Property(e => e.OldName)
                .HasMaxLength(10)
                .IsFixedLength();

            builder.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}