using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CategoryParamsConfiguration : IEntityTypeConfiguration<CatagoryParams>
    {
        public void Configure(EntityTypeBuilder<CatagoryParams> builder)
        {
            builder.Property(e => e.ItypeCode)
                .HasColumnName("ITypeCode")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.ParamsName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.UpdateAt).HasColumnType("datetime");

        }
    }
}
