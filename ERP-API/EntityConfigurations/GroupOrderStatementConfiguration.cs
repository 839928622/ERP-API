using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GroupOrderStatementConfiguration : IEntityTypeConfiguration<GroupOrderStatement>
    {
        public void Configure(EntityTypeBuilder<GroupOrderStatement> builder)
        {
            builder.Property(e => e.ChargeOff).HasColumnType("money");

            builder.Property(e => e.Memo)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.PaidMoney).HasColumnType("money");

            builder.Property(e => e.PayStatus)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.SumMoney).HasColumnType("money");

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}