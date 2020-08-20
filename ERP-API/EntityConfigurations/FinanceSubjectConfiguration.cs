using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class FinanceSubjectConfiguration : IEntityTypeConfiguration<FinanceSubject>
    {
        public void Configure(EntityTypeBuilder<FinanceSubject> builder)
        {
            builder.Property(e => e.AddAt).HasColumnType("datetime");

            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("科目编号");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(500)
                .HasComment("科目名称");

            builder.Property(e => e.Pcode)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("上级编号");

            builder.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("类型");

            builder.Property(e => e.UpdatetAt).HasColumnType("datetime");
        }
    }
}