using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CustomerSettingConfiguration : IEntityTypeConfiguration<CustomerSetting>
    {
        public void Configure(EntityTypeBuilder<CustomerSetting> builder)
        {
            builder.HasComment("重要客户自定义设置");

            builder.Property(e => e.Id).HasComment("PK");

            builder.Property(e => e.Alias)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("别名");

            builder.Property(e => e.CustomerId).HasComment("客户编号");

            builder.Property(e => e.Image)
                .IsRequired()
                .HasMaxLength(2000)
                .HasComment("图片");

            builder.Property(e => e.Logo)
                .IsRequired()
                .HasMaxLength(2000)
                .HasComment("Logo");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("名称");

            builder.Property(e => e.Tenant).HasComment("租户");
        }
    }
}