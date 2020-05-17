using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DeliveryLineMemberConfiguration : IEntityTypeConfiguration<DeliveryLineMember>
    {
        public void Configure(EntityTypeBuilder<DeliveryLineMember> builder)
        {
            builder.Property(e => e.Distance).HasComment("配送距离（公里）");

            builder.Property(e => e.Remark).HasMaxLength(100);

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}