using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GroupPayConfiguration : IEntityTypeConfiguration<GroupPay>
    {
        public void Configure(EntityTypeBuilder<GroupPay> builder)
        {
            builder.Property(e => e.ChargeOff).HasColumnType("money");

            builder.Property(e => e.Memo)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.PayDate).HasColumnType("datetime");

            builder.Property(e => e.PayMoney).HasColumnType("money");

            builder.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}