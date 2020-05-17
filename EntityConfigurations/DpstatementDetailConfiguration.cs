using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DpstatementDetailConfiguration : IEntityTypeConfiguration<DpstatementDetail>
    {
        public void Configure(EntityTypeBuilder<DpstatementDetail> builder)
        {
            builder.ToTable("DPStatementDetail");

            builder.HasComment("分销商对账明细");

            builder.HasIndex(e => e.DpstatementId)
                .HasName("IX_DPStatementId");

            builder.HasIndex(e => e.OrderId)
                .HasName("IX_OrderId");

            builder.Property(e => e.DpstatementId).HasColumnName("DPStatementId");
        }
    }
}