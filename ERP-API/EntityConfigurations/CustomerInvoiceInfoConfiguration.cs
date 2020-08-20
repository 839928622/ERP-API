using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CustomerInvoiceInfoConfiguration : IEntityTypeConfiguration<CustomerInvoiceInfo>
    {
        public void Configure(EntityTypeBuilder<CustomerInvoiceInfo> builder)
        {
            builder.Property(e => e.InvoiceAccount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("开户行账号");

            builder.Property(e => e.InvoiceAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("地址");

            builder.Property(e => e.InvoiceBank)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("开户行");

            builder.Property(e => e.InvoiceMemo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("发票备注");

            builder.Property(e => e.InvoicePhone)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceTaxNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("税号");

            builder.Property(e => e.MemberName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')");
        }
    }
}