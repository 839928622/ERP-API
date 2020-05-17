using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DellOrderGoodsPoConfiguration : IEntityTypeConfiguration<DellOrderGoodsPo>
    {
        public void Configure(EntityTypeBuilder<DellOrderGoodsPo> builder)
        {
            builder.Property(e => e.GoodsName).HasMaxLength(500);

            builder.Property(e => e.GoodsPrice).HasColumnType("money");

            builder.Property(e => e.Po)
                .HasColumnName("PO")
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("生成的传给戴尔的订单号");

            builder.Property(e => e.Status)
                .HasMaxLength(50)
                .HasComment("状态");

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}