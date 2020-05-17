using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsTypeConfiguration : IEntityTypeConfiguration<GoodsType>
    {
        public void Configure(EntityTypeBuilder<GoodsType> builder)
        {
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.DefaultSource)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.DefaultUnit)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.IsLeaf)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("是否是叶子分类（一般是3级），只允许在叶子分类下添加商品");

            builder.Property(e => e.IsVisible)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Pcode)
                .IsRequired()
                .HasColumnName("PCode")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PointRate)
                .HasDefaultValueSql("((100))")
                .HasComment("积分比率");

            builder.Property(e => e.PriceArea)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("价格区间展示");

            builder.Property(e => e.Py)
                .HasColumnName("PY")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}