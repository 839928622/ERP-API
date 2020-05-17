using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DistributionReceiveMoneyConfiguration : IEntityTypeConfiguration<DistributionReceiveMoney>
    {
        public void Configure(EntityTypeBuilder<DistributionReceiveMoney> builder)
        {
            builder.Property(e => e.BranchId).HasComment("收款方");

            builder.Property(e => e.ChargeOff)
                .HasColumnType("money")
                .HasComment("销账金额，与订单的销账金额相等");

            builder.Property(e => e.Memo)
                .HasMaxLength(500)
                .HasComment("收款备注");

            builder.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("支付方式");

            builder.Property(e => e.PbranchId)
                .HasColumnName("PBranchId")
                .HasComment("付款方");

            builder.Property(e => e.ReceiveAccount).HasComment("付款账户，Sys_BranchBankInfo的编号");

            builder.Property(e => e.ReceiveDate)
                .HasColumnType("datetime")
                .HasComment("收款日期");

            builder.Property(e => e.ReceiveMoney)
                .HasColumnType("money")
                .HasComment("实际收款金额");

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");

            builder.Property(e => e.UserId).HasComment("收款操作人");
        }
    }
}