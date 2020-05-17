using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class FinanceAuditConfiguration : IEntityTypeConfiguration<FinanceAudit>
    {
        public void Configure(EntityTypeBuilder<FinanceAudit> builder)
        {
            builder.Property(e => e.FinanceData).HasColumnType("text");

            builder.Property(e => e.Remark).HasMaxLength(1000);

            builder.Property(e => e.Status).HasMaxLength(50);

            builder.Property(e => e.Type).HasMaxLength(50);

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}