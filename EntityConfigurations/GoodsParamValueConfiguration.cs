using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsParamValueConfiguration : IEntityTypeConfiguration<GoodsParamValue>
    {
        public void Configure(EntityTypeBuilder<GoodsParamValue> builder)
        {
            builder.HasIndex(e => e.GoodsId)
                .HasName("IX_GoodsParamValue");

            builder.HasIndex(e => new { e.ParamId, e.Value })
                .HasName("IX_GoodsParamValue_1");

            builder.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}