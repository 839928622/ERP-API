using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsTypeUpdateConfiguration : IEntityTypeConfiguration<GoodsTypeUpdate>
    {
        public void Configure(EntityTypeBuilder<GoodsTypeUpdate> builder)
        {
            builder.Property(e => e.TypeCode)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.TypeName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}