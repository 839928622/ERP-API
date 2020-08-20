using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class DostatementDetailConfiguration : IEntityTypeConfiguration<DostatementDetail>
    {
        public void Configure(EntityTypeBuilder<DostatementDetail> builder)
        {
            builder.ToTable("DOStatementDetail");
        }
    }
}