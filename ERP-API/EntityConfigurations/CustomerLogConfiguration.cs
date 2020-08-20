using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CustomerLogConfiguration : IEntityTypeConfiguration<CustomerLog>
    {
        public void Configure(EntityTypeBuilder<CustomerLog> builder)
        {
            builder.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasComment("添加时间");

            builder.Property(e => e.Category)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("操作类别");

            builder.Property(e => e.Customer)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Operate)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("操作");

            builder.Property(e => e.Tracking).HasComment("修改详细信息，扩展字段");

            builder.Property(e => e.UserId).HasComment("操作人Id(Sys_Users)");

            builder.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("操作人名称");
        }
    }
}