using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsPhotoConfiguration : IEntityTypeConfiguration<GoodsPhoto>
    {
        public void Configure(EntityTypeBuilder<GoodsPhoto> builder)
        {
            builder.HasIndex(e => e.GoodsId)
                .HasName("goodsphotoindex");

            builder.Property(e => e.Height).HasDefaultValueSql("((0))");

            builder.Property(e => e.Photo100Url)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.Photo250Url)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.PhotoUrl)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("图片在文件服务器上的访问路径");

            builder.Property(e => e.Sort).HasDefaultValueSql("((10))");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Width).HasDefaultValueSql("((0))");
        }
    }
}