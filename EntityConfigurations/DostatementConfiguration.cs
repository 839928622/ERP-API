using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DostatementConfiguration : IEntityTypeConfiguration<Dostatement>
    {
        public void Configure(EntityTypeBuilder<Dostatement> builder)
        {
            builder.ToTable("DOStatement");

            builder.Property(e => e.ApplyInvoiceMoney).HasColumnType("money");

            builder.Property(e => e.ApplyReceiveMoney).HasColumnType("money");

            builder.Property(e => e.ChargeOff).HasColumnType("money");

            builder.Property(e => e.EndDate).HasColumnType("datetime");

            builder.Property(e => e.InvoiceChargeOff).HasColumnType("money");

            builder.Property(e => e.InvoiceMoney).HasColumnType("money");

            builder.Property(e => e.InvoiceStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceType)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Memo)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.PaidMoney).HasColumnType("money");

            builder.Property(e => e.PayStatus)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.Property(e => e.SumGoodsAmount).HasColumnType("money");

            builder.Property(e => e.SumMoney).HasColumnType("money");

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}