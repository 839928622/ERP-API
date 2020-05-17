using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class EmailInvoiceSettingConfiguration : IEntityTypeConfiguration<EmailInvoiceSetting>
    {
        public void Configure(EntityTypeBuilder<EmailInvoiceSetting> builder)
        {
            builder.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasComment("添加时间");

            builder.Property(e => e.AppKey)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.AppSecret)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.IsEnable).HasComment("是否开启");

            builder.Property(e => e.PlatApi)
                .IsRequired()
                .HasColumnName("PlatAPI")
                .IsUnicode(false)
                .HasComment("平台电子发票API");

            builder.Property(e => e.PlatIdentity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("平台身份认证编号");

            builder.Property(e => e.SaleAddress)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasComment("销售方地址");

            builder.Property(e => e.SaleBank)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("销售方开户行");

            builder.Property(e => e.SaleBankAccount)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("销售方开户行账号");

            builder.Property(e => e.SaleName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("销售方名称");

            builder.Property(e => e.SalePhone)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("销售方电话");

            builder.Property(e => e.SaleTaxNum)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("销售方税号");

            builder.Property(e => e.Token)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasComment("更新时间");
        }
    }
}