using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IBeiJingGoodsMap : IEntityTypeConfiguration<Models.IBeiJingGoodsMap>
    {
        public void Configure(EntityTypeBuilder<Models.IBeiJingGoodsMap> builder)
        {
            builder.ToTable("I_BeiJingGoodsMap");

            builder.Property(e => e.IBeiJingProductId)
                .IsRequired()
                .HasColumnName("I_BeiJingProductId")
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}