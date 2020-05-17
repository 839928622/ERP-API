using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class FinanceRecordConfiguration : IEntityTypeConfiguration<FinanceRecord>
    {
        public void Configure(EntityTypeBuilder<FinanceRecord> builder)
        {
            builder.Property(e => e.AddAt).HasColumnType("datetime");

            builder.Property(e => e.Balance)
                .HasColumnType("money")
                .HasComment("余额");

            builder.Property(e => e.BankId).HasComment("账户编号");

            builder.Property(e => e.BankInfo)
                .HasMaxLength(1000)
                .HasComment("开户行+账号名称");

            builder.Property(e => e.DebtorId).HasComment("借方");

            builder.Property(e => e.DebtorName)
                .IsRequired()
                .HasMaxLength(500)
                .HasComment("借方名称");

            builder.Property(e => e.InitBalance)
                .HasColumnType("money")
                .HasComment("原金额");

            builder.Property(e => e.LenderId).HasComment("贷方");

            builder.Property(e => e.LenderName)
                .IsRequired()
                .HasMaxLength(500)
                .HasComment("贷方名称");

            builder.Property(e => e.Operate)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("操作");

            builder.Property(e => e.OperateAmount)
                .HasColumnType("money")
                .HasComment("操作金额");

            builder.Property(e => e.OpreteDate)
                .HasColumnType("datetime")
                .HasComment("实际收/付款日期");

            builder.Property(e => e.PayType)
                .HasMaxLength(200)
                .HasComment("支付方式");

            builder.Property(e => e.Remark)
                .HasMaxLength(4000)
                .HasComment("备注");

            builder.Property(e => e.SubjectCode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("科目code");

            builder.Property(e => e.SubjectName)
                .HasMaxLength(500)
                .HasComment("科目名称");

            builder.Property(e => e.Tpn)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("第三方");

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");
        }
    }
}