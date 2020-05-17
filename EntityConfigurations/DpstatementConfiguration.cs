using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DpstatementConfiguration : IEntityTypeConfiguration<Dpstatement>
    {
        public void Configure(EntityTypeBuilder<Dpstatement> builder)
        {
            builder.ToTable("DPStatement");

            builder.HasComment("分销商对账");

            builder.HasIndex(e => e.BranchId)
                .HasName("IX_BranchId");

            builder.HasIndex(e => e.InvoiceStatus)
                .HasName("IX_InvoiceStatus");

            builder.HasIndex(e => e.PayStatus)
                .HasName("IX_PayStatus");

            builder.HasIndex(e => e.SupplierId)
                .HasName("IX_PurchaseStatement");

            builder.Property(e => e.BranchId).HasComment("租户");

            builder.Property(e => e.ChargeOff)
                .HasColumnType("money")
                .HasComment("销账金额");

            builder.Property(e => e.InvoiceApplyMoney)
                .HasColumnType("money")
                .HasComment("收票申请金额");

            builder.Property(e => e.InvoiceChargeOff)
                .HasColumnType("money")
                .HasComment("收票销账金额");

            builder.Property(e => e.InvoiceMoney)
                .HasColumnType("money")
                .HasComment("收票金额");

            builder.Property(e => e.InvoiceStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('未收票')")
                .HasComment("未收票、已收票、部分收票");

            builder.Property(e => e.Memo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("备注");

            builder.Property(e => e.PaidApplyMoney)
                .HasColumnType("money")
                .HasComment("付款申请金额");

            builder.Property(e => e.PaidMoney)
                .HasColumnType("money")
                .HasComment("收款金额");

            builder.Property(e => e.PayStatus)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('未付款')")
                .HasComment("未付款、已付款、部分付款");

            builder.Property(e => e.SumMoney)
                .HasColumnType("money")
                .HasComment("对账单总额");

            builder.Property(e => e.SupplierId).HasComment("分销商");

            builder.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                .HasComment("操作时间");

            builder.Property(e => e.UpdateBy).HasComment("操作人");
        }
    }
}