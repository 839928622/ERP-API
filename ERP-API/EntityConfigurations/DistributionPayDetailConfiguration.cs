using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DistributionPayDetailConfiguration : IEntityTypeConfiguration<DistributionPayDetail>
    {
        public void Configure(EntityTypeBuilder<DistributionPayDetail> builder)
        {
            builder.HasComment("分销收款明细");

            builder.HasIndex(e => e.GoodsId)
                .HasName("IX_GoodsId");

            builder.HasIndex(e => e.OrderId)
                .HasName("IX_OrderId");

            builder.HasIndex(e => e.PayId)
                .HasName("IX_PayId");

            builder.Property(e => e.Id).HasComment("PK");

            builder.Property(e => e.Amount)
                .HasColumnType("money")
                .HasComment("明细实收金额");

            builder.Property(e => e.ChargeOffAmount)
                .HasColumnType("money")
                .HasComment("销账金额");

            builder.Property(e => e.GoodsId).HasComment("商品Id");

            builder.Property(e => e.IsDelete).HasComment("是否删除");

            builder.Property(e => e.Num).HasComment("数量");

            builder.Property(e => e.OrderId).HasComment("订单Id");

            builder.Property(e => e.PayId).HasComment("FK");

            builder.Property(e => e.Price)
                .HasColumnType("money")
                .HasComment("单价");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasComment("操作时间");
        }
    }
}