using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class AttachedFilConfiguration : IEntityTypeConfiguration<AttachedFil>
    {
        public void Configure(EntityTypeBuilder<AttachedFil> builder)
        {
            //Fluent API
            builder.Property(e => e.AddAt).HasColumnType("datetime");
            builder.Property(e => e.FileUrl)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}