using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class
        DistributionCustomerReceiveMoneyDetailConfiguration : IEntityTypeConfiguration<
            DistributionCustomerReceiveMoneyDetail>
    {
        public void Configure(EntityTypeBuilder<DistributionCustomerReceiveMoneyDetail> builder)
        {
            builder.Property(e => e.Amount)
                .HasColumnType("money")
                .HasComment("明细实收金额");

            builder.Property(e => e.ChargeOffAmount)
                .HasColumnType("money")
                .HasComment("明细销账金额");

            builder.Property(e => e.GoodsName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Price).HasColumnType("money");

            builder.Property(e => e.ReceiveMoneyId).HasComment("分销订单收款记录表Id");

            builder.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");
        }
    }
}