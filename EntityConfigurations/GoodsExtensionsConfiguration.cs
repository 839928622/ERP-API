using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsExtensionsConfiguration : IEntityTypeConfiguration<GoodsExtensions>
    {
        public void Configure(EntityTypeBuilder<GoodsExtensions> builder)
        {
            builder.Property(e => e.Id).HasComment("PK");

            builder.Property(e => e.GoodsId).HasComment("商品编号");

            builder.Property(e => e.Remark)
                .HasColumnType("text")
                .HasComment("规格内容");

            builder.Property(e => e.VirtualSales).HasComment("商品虚拟销量，用于应对投标");
        }
    }
}