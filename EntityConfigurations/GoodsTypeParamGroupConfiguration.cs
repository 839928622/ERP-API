using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsTypeParamGroupConfiguration : IEntityTypeConfiguration<GoodsTypeParamGroup>
    {
        public void Configure(EntityTypeBuilder<GoodsTypeParamGroup> builder)
        {
            builder.HasIndex(e => new {e.TypeId, e.GroupName, e.BranchId})
                .HasName("IX_GoodsTypeParamGroup")
                .IsUnique();

            builder.Property(e => e.GroupName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ParamSource)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.Sort).HasDefaultValueSql("((10))");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}