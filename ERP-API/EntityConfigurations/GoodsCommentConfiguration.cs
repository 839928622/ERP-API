using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsCommentConfiguration : IEntityTypeConfiguration<GoodsComment>
    {
        public void Configure(EntityTypeBuilder<GoodsComment> builder)
        {
            builder.Property(e => e.Content)
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.Label)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Level).HasDefaultValueSql("((3))");

            builder.Property(e => e.OrderTime).HasColumnType("datetime");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}