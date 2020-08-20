using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DefaultStoreConfiguration : IEntityTypeConfiguration<DefaultStore>
    {
        public void Configure(EntityTypeBuilder<DefaultStore> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.OrderType)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Place)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.StoreId).HasDefaultValueSql("('0')");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}