using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DistributionCustomerInvoiceConfiguration : IEntityTypeConfiguration<DistributionCustomerInvoice>
    {
        public void Configure(EntityTypeBuilder<DistributionCustomerInvoice> builder)
        {
            builder.Property(e => e.BranchId).HasComment("开票方，即销方");

            builder.Property(e => e.BuyerAddress)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasComment("购方地址");

            builder.Property(e => e.BuyerBank)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("购方开户行");

            builder.Property(e => e.BuyerBankAccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("购方开户行账号");

            builder.Property(e => e.BuyerName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("购方名称");

            builder.Property(e => e.BuyerPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("购方电话");

            builder.Property(e => e.BuyerTaxNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("购方税号");

            builder.Property(e => e.ChargeOff)
                .HasColumnType("money")
                .HasComment("销账金额");

            builder.Property(e => e.CustomerId).HasComment("客户编号");

            builder.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("客户名称");

            builder.Property(e => e.DeliveryType).HasComment("配送方式");

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("联系人邮箱");

            builder.Property(e => e.InvoiceCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("发票代码");

            builder.Property(e => e.InvoiceDate)
                .HasColumnType("datetime")
                .HasComment("开票日期");

            builder.Property(e => e.InvoiceMoney)
                .HasColumnType("money")
                .HasComment("开票金额");

            builder.Property(e => e.InvoiceNo)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("发票号码");

            builder.Property(e => e.InvoiceType).HasComment("发票类型");

            builder.Property(e => e.LinkMan)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("联系人名称");

            builder.Property(e => e.LinkManId).HasComment("联系人编号");

            builder.Property(e => e.Memo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("开票备注");

            builder.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("联系人手机号");

            builder.Property(e => e.SaleAddress)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasComment("销方地址");

            builder.Property(e => e.SaleBank)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("销方开户行");

            builder.Property(e => e.SaleBankAccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("销方开户行账号");

            builder.Property(e => e.SaleName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("销方名称");

            builder.Property(e => e.SalePhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("销方电话");

            builder.Property(e => e.SaleTaxNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("销方税号");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasComment("开票操作时间");

            builder.Property(e => e.UserId).HasComment("开票操作人");
        }
    }
}