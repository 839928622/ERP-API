using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsConfiguration : IEntityTypeConfiguration<Goods>
    {
        public void Configure(EntityTypeBuilder<Goods> builder)
        {
            builder.HasIndex(e => e.BranchId)
                .HasName("NonClusteredIndex-20181031-134951");

            builder.HasIndex(e => e.BrandId)
                .HasName("NonClusteredIndex-20181031-135019");

            builder.HasIndex(e => e.TypeId)
                .HasName("NonClusteredIndex-20181031-135038");

            builder.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.BranchId).HasComment("0：共有商品");

            builder.Property(e => e.BrandId).HasComment("品牌Id");

            builder.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.CombinationType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('单一')")
                .HasComment("商品的组合类型：单一、母商品、子商品、组合商品");

            builder.Property(e => e.Cuxiao)
                .HasColumnName("cuxiao")
                .HasColumnType("numeric(18, 2)")
                .HasComment(">0说明是促销商品");

            builder.Property(e => e.CuxiaoDate)
                .HasColumnName("cuxiaoDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(((1949)-(10))-(1))")
                .HasComment("促销截止日期");

            builder.Property(e => e.DataSource).HasComment("是否抓取/下载");

            builder.Property(e => e.DisplayName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('‘’')");

            builder.Property(e => e.DonvvSku).HasColumnName("DonvvSKU");

            builder.Property(e => e.Feature)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.HomeImage)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('‘’')");

            builder.Property(e => e.InPrice)
                .HasColumnType("decimal(18, 4)")
                .HasComment("最新进价");

            builder.Property(e => e.InnerId)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.IsEnable)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("是否有效，1：有效，0：禁用商品");

            builder.Property(e => e.IsWeb)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("网站是否可见");

            builder.Property(e => e.MinimumQuantity).HasDefaultValueSql("((1))");

            builder.Property(e => e.Model)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("商品名称，不包括品牌和型号");

            builder.Property(e => e.PackingList)
                .IsRequired()
                .HasColumnType("text")
                .HasComment("包装清单");

            builder.Property(e => e.ParentId).HasComment(">1 说明是子商品，0：普通商品，1：母商品");

            builder.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            builder.Property(e => e.PriceExtend).HasColumnType("decimal(10, 2)");

            builder.Property(e => e.Py)
                .IsRequired()
                .HasColumnName("PY")
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('‘’')");

            builder.Property(e => e.Rate)
                .HasDefaultValueSql("((-1))")
                .HasComment("积分比例");

            builder.Property(e => e.Recommend).HasComment("推荐度");

            builder.Property(e => e.RecommendDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(((1900)-(1))-(1))");

            builder.Property(e => e.SaleCount).HasComment("销售次数，每日集中计算");

            builder.Property(e => e.SaleNumber).HasComment("销售数量，每日集中计算");

            builder.Property(e => e.SalesAnalysis)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('正常品')");

            builder.Property(e => e.Service)
                .IsRequired()
                .HasColumnType("text")
                .HasDefaultValueSql("('‘’')")
                .HasComment("服务条款");

            builder.Property(e => e.Sn)
                .IsRequired()
                .HasColumnName("SN")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Tags)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasComment("商品标签");

            builder.Property(e => e.TaxCode).HasMaxLength(50);

            builder.Property(e => e.Tpn)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Tpname)
                .HasColumnName("TPName")
                .HasMaxLength(500);

            builder.Property(e => e.TypeId).HasComment("商品类别Id");

            builder.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('‘’')")
                .HasComment("基本单位");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        }
    }
}