using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsCaptchaConfiguration : IEntityTypeConfiguration<GoodsCaptcha>
    {
        public void Configure(EntityTypeBuilder<GoodsCaptcha> builder)
        {
            builder.Property(e => e.Captcha)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}