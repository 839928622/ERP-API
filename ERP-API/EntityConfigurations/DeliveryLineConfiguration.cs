using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DeliveryLineConfiguration : IEntityTypeConfiguration<DeliveryLine>
    {
        public void Configure(EntityTypeBuilder<DeliveryLine> builder)
        {
            builder.HasIndex(e => new { e.BranchId, e.LineName })
                .HasName("IX_DeliveryLine")
                .IsUnique();

            builder.Property(e => e.BranchId).HasDefaultValueSql("((1))");

            builder.Property(e => e.LineName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LineRange).HasMaxLength(200);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}