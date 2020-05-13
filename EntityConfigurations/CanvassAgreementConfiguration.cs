using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CanvassAgreementConfiguration : IEntityTypeConfiguration<CanvassAgreement>
    {
        public void Configure(EntityTypeBuilder<CanvassAgreement> builder)
        {
            builder.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.AgreementContent)
                .IsRequired()
                .HasDefaultValueSql("('')");
        }
    }
}