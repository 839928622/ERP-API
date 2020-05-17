using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DistributionPayConfiguration : IEntityTypeConfiguration<DistributionPay>
    {
        public void Configure(EntityTypeBuilder<DistributionPay> builder)
        {
            builder.HasIndex(e => e.BranchId)
                .HasName("IX_BranchId");

            builder.HasIndex(e => e.ChildBranchId)
                .HasName("IX_ChildBranchId");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_UserId");

            builder.Property(e => e.BranchId).HasComment("付款方");

            builder.Property(e => e.ChargeOff)
                .HasColumnType("money")
                .HasComment("销账金额，与订单的销账金额相等");

            builder.Property(e => e.ChildBranchId).HasComment("收款方");

            builder.Property(e => e.Memo)
                .HasMaxLength(500)
                .HasComment("付款备注");

            builder.Property(e => e.PayAccount).HasComment("付款账号");

            builder.Property(e => e.PayDate)
                .HasColumnType("datetime")
                .HasComment("付款日期");

            builder.Property(e => e.PayMoney)
                .HasColumnType("money")
                .HasComment("实际收款金额");

            builder.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("支付方式");

            builder.Property(e => e.StatementId).HasComment("对账单号");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasComment("操作时间");

            builder.Property(e => e.UserId).HasComment("操作人");
        }
    }
}