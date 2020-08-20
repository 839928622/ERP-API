using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsDefaultInfoConfiguration : IEntityTypeConfiguration<GoodsDefaultInfo>
    {
        public void Configure(EntityTypeBuilder<GoodsDefaultInfo> builder)
        {
            builder.Property(e => e.AddTime).HasColumnType("datetime");

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}