using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DistributionOrderStateConfiguration : IEntityTypeConfiguration<DistributionOrderState>
    {
        public void Configure(EntityTypeBuilder<DistributionOrderState> builder)
        {
            builder.Property(e => e.AllocationTime).HasColumnType("datetime");

            builder.Property(e => e.ArriveTime).HasColumnType("datetime");

            builder.Property(e => e.DeliveryTime).HasColumnType("datetime");

            builder.Property(e => e.InvoiceChargeOff).HasColumnType("money");

            builder.Property(e => e.InvoiceStatus).HasComment("收票状态：0:未收票；1：已收票；2：部分收票");

            builder.Property(e => e.IsLocked)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.PickTime).HasColumnType("datetime");

            builder.Property(e => e.PrintTime).HasColumnType("datetime");

            builder.Property(e => e.ReceiveChargeOff).HasColumnType("money");

            builder.Property(e => e.ReceiveMoneyStatus).HasComment("收款状态：0:未收款；1：已收款；2：部分收款");

            builder.Property(e => e.ServiceResponseTime).HasColumnType("datetime");

            builder.Property(e => e.SumMoney).HasColumnType("money");
        }
    }
}