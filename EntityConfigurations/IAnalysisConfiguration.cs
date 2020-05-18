using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class IAnalysisConfiguration : IEntityTypeConfiguration<IAnalysis>
    {
        public void Configure(EntityTypeBuilder<IAnalysis> builder)
        {
            builder.ToTable("I_Analysis");

            builder.Property(e => e.AddTime).HasColumnType("datetime");

            builder.Property(e => e.AppKey)
                .HasMaxLength(3000)
                .IsUnicode(false);

            builder.Property(e => e.AppSecret)
                .HasMaxLength(3000)
                .IsUnicode(false);

            builder.Property(e => e.ExpiresTime).HasColumnType("datetime");

            builder.Property(e => e.Token)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}