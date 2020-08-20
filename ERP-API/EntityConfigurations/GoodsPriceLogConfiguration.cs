using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class GoodsPriceLogConfiguration : IEntityTypeConfiguration<GoodsPriceLog>
    {
        public void Configure(EntityTypeBuilder<GoodsPriceLog> builder)
        {
            builder.Property(e => e.BranchId).HasDefaultValueSql("((1))");

            builder.Property(e => e.Memo)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.NewPrice).HasColumnType("money");

            builder.Property(e => e.OldPrice).HasColumnType("money");

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}