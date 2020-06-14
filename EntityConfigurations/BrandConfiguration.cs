using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {

            builder.HasIndex(e => new { e.BranchId, e.FullName })
                .HasName("IX_Brand")
                .IsUnique();

            builder.Property(e => e.Id).HasComment("品牌编号");

            builder.Property(e => e.Company)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("公司");

            builder.Property(e => e.EnglishName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("品牌英文名称");

            builder.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("品牌全程");

            builder.Property(e => e.LogoUrl)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("品牌名称");

            builder.Property(e => e.ProductPlace)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Py)
                .HasColumnName("PY")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.WebSite)
                .HasMaxLength(500)
                .IsUnicode(false);

        }
    }
}
