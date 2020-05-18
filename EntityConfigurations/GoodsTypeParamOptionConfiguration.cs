using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsTypeParamOptionConfiguration : IEntityTypeConfiguration<GoodsTypeParamOption>
    {
        public void Configure(EntityTypeBuilder<GoodsTypeParamOption> builder)
        {
            builder.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}