using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CustomerPreReceiveMoneyConfiguration : IEntityTypeConfiguration<CustomerPreReceiveMoney>
    {
        public void Configure(EntityTypeBuilder<CustomerPreReceiveMoney> builder)
        {
            builder.Property(e => e.ActualPayTime).HasColumnType("datetime");

            builder.Property(e => e.Balance)
                .HasColumnType("money")
                .HasComment("余额");

            builder.Property(e => e.BranchId).HasDefaultValueSql("((1))");

            builder.Property(e => e.CustomerId).HasComment("客户Id");

            builder.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("客户名称");

            builder.Property(e => e.InitialBalance)
                .HasColumnType("money")
                .HasComment("期初金额");

            builder.Property(e => e.Memo)
                .HasColumnType("text")
                .HasComment("备注");

            builder.Property(e => e.Operate)
                .IsRequired()
                .HasMaxLength(10)
                .HasComment("操作(预收、收款、撤销)");

            builder.Property(e => e.OperatorId).HasComment("操作人Id");

            builder.Property(e => e.OperatorName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("操作人名称");

            builder.Property(e => e.OrderStatementId).HasComment("对账单Id");

            builder.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.PreReceiveMoney)
                .HasColumnType("money")
                .HasComment("预收金额");

            builder.Property(e => e.ReceiveAccount)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.ReceiveMoney)
                .HasColumnType("money")
                .HasComment("收款金额");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasComment("更新时间");
        }
    }
}