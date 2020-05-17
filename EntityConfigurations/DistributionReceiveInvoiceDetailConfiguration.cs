using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class
        DistributionReceiveInvoiceDetailConfiguration : IEntityTypeConfiguration<DistributionReceiveInvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<DistributionReceiveInvoiceDetail> builder)
        {
            builder.HasComment("分销收票明细");

            builder.HasIndex(e => e.GoodsId)
                .HasName("IX_GoodsId");

            builder.HasIndex(e => e.OrderId)
                .HasName("IX_OrderId");

            builder.HasIndex(e => e.ReceiveInvoiceId)
                .HasName("IX_ReceiveInvoiceId");

            builder.Property(e => e.Amount)
                .HasColumnType("money")
                .HasComment("开票金额");

            builder.Property(e => e.ChargeOffAmount)
                .HasColumnType("money")
                .HasComment("销账金额");

            builder.Property(e => e.GoodsId).HasComment("商品编号");

            builder.Property(e => e.Num).HasComment("数量");

            builder.Property(e => e.OrderId).HasComment("订单编号");

            builder.Property(e => e.Price)
                .HasColumnType("money")
                .HasComment("单价");

            builder.Property(e => e.ReceiveInvoiceId).HasComment("DistributionReceiveInvoice表Id");

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