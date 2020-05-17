using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class
        DistributionCustomerInvoiceDetailConfiguration : IEntityTypeConfiguration<DistributionCustomerInvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<DistributionCustomerInvoiceDetail> builder)
        {
            builder.Property(e => e.Amount)
                .HasColumnType("money")
                .HasComment("金额");

            builder.Property(e => e.ChargeOffAmount).HasColumnType("money");

            builder.Property(e => e.GoodsId).HasComment("商品编号");

            builder.Property(e => e.InvoiceId).HasComment("DistributionCustomerInvoice表Id");

            builder.Property(e => e.Num).HasComment("数量");

            builder.Property(e => e.OrderId).HasComment("订单编号");

            builder.Property(e => e.Price)
                .HasColumnType("money")
                .HasComment("单价");

            builder.Property(e => e.TaxCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("商品税收编码");

            builder.Property(e => e.TaxRate)
                .HasColumnType("money")
                .HasComment("税率");

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}