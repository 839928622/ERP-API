using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsTypeParamConfiguration : IEntityTypeConfiguration<GoodsTypeParam>
    {
        public void Configure(EntityTypeBuilder<GoodsTypeParam> builder)
        {
            builder.HasIndex(e => new {e.GroupId, e.Name})
                .HasName("IX_GoodsTypeParams")
                .IsUnique();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);
        }
    }
}