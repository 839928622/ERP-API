using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    // ReSharper disable once InconsistentNaming
    public class IBeiJingGoodsConfiguration : IEntityTypeConfiguration<IBeiJingGoods>
    {
        public void Configure(EntityTypeBuilder<IBeiJingGoods> builder)
        {
            builder.ToTable("I_BeiJingGoods");

            builder.Property(e => e.IBrand)
                .HasColumnName("I_Brand")
                .HasMaxLength(255);

            builder.Property(e => e.ICategory)
                .HasColumnName("I_Category")
                .HasMaxLength(255);

            builder.Property(e => e.IProductId)
                .HasColumnName("I_ProductId")
                .HasMaxLength(255);

            builder.Property(e => e.IProductName)
                .HasColumnName("I_ProductName")
                .HasMaxLength(500);

            builder.Property(e => e.ISalePrice)
                .HasColumnName("I_SalePrice")
                .HasColumnType("decimal(18, 2)");
        }
    }
}