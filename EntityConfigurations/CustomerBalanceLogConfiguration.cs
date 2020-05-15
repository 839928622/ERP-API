using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CustomerBalanceLogConfiguration : IEntityTypeConfiguration<CustomerBalanceLog>
    {
        public void Configure(EntityTypeBuilder<CustomerBalanceLog> builder)
        {
            builder.HasComment("客户余额日志");

            builder.HasIndex(e => e.CreateDate)
                .HasName("CreateDate");

            builder.HasIndex(e => e.CustomerId)
                .HasName("CustomerId");

            builder.HasIndex(e => e.CustomerName)
                .HasName("CustomerName");

            builder.HasIndex(e => e.DeptId)
                .HasName("DeptId");

            builder.HasIndex(e => e.RelationId)
                .HasName("RelationId");

            builder.HasIndex(e => e.UserId)
                .HasName("UserId");

            builder.Property(e => e.Id).HasComment("PK");

            builder.Property(e => e.Amount)
                .HasColumnType("money")
                .HasComment("金额");

            builder.Property(e => e.BranchId).HasComment("租户编号");

            builder.Property(e => e.Change)
                .HasColumnType("money")
                .HasComment("变更值");

            builder.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasComment("创建时间");

            builder.Property(e => e.CreationId).HasComment("创建人");

            builder.Property(e => e.CustomerId).HasComment("客户编号");

            builder.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("客户名称");

            builder.Property(e => e.DeptId).HasComment("部门编号");

            builder.Property(e => e.DeptName)
                .HasMaxLength(200)
                .HasComment("部门名称");

            builder.Property(e => e.Direction).HasComment("1、增加 2、减少");

            builder.Property(e => e.RelationId).HasComment("关联订单编号");

            builder.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");

            builder.Property(e => e.UserId).HasComment("联系人编号");

            builder.Property(e => e.UserName)
                .HasMaxLength(200)
                .HasComment("联系人名称");
        }
    }
}