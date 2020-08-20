using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsGroupDetailConfiguration : IEntityTypeConfiguration<GoodsGroupDetail>
    {
        public void Configure(EntityTypeBuilder<GoodsGroupDetail> builder)
        {
            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}