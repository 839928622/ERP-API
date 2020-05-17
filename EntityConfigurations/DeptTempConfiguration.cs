using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DeptTempConfiguration : IEntityTypeConfiguration<DeptTemp>
    {
        public void Configure(EntityTypeBuilder<DeptTemp> builder)
        {
            builder.Property(e => e.Balance).HasColumnType("money");

            builder.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Pcode)
                .HasColumnName("PCode")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}