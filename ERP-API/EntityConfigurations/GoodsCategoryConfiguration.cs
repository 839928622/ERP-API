using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsCategoryConfiguration : IEntityTypeConfiguration<GoodsCategory>
    {
        public void Configure(EntityTypeBuilder<GoodsCategory> builder)
        {
            builder.HasComment("虚拟类目");

            builder.HasIndex(e => e.ParentId)
                .HasName("Index_ParentId");

            builder.Property(e => e.Id).HasComment("PK");

            builder.Property(e => e.CreationTime)
                .HasColumnType("datetime")
                .HasComment("创建时间");

            builder.Property(e => e.CreatorUserId).HasComment("创建用户");

            builder.Property(e => e.DeleterUserId).HasComment("删除用户");

            builder.Property(e => e.DeletionTime)
                .HasColumnType("datetime")
                .HasComment("删除时间");

            builder.Property(e => e.GoodsType).HasComment("商品类目");

            builder.Property(e => e.Icon)
                .HasMaxLength(200)
                .HasComment("图标");

            builder.Property(e => e.IsDeleted).HasComment("是否删除");

            builder.Property(e => e.LastModificationTime)
                .HasColumnType("datetime")
                .HasComment("修改时间");

            builder.Property(e => e.LastModifierUserId).HasComment("修改用户");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("名称");

            builder.Property(e => e.Order).HasComment("排序");

            builder.Property(e => e.ParentId).HasComment("父级Id");

            builder.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");

            builder.Property(e => e.Tenant).HasComment("租户Id");

            builder.Property(e => e.Url)
                .HasMaxLength(200)
                .HasComment("链接");
        }
    }
}