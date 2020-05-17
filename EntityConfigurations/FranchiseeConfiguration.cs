using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class FranchiseeConfiguration : IEntityTypeConfiguration<Franchisee>
    {
        public void Configure(EntityTypeBuilder<Franchisee> builder)
        {
            builder.HasComment("加盟商");

            builder.Property(e => e.CompanyAddress)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("公司详细地址");

            builder.Property(e => e.CompanyArea)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("公司地址区县");

            builder.Property(e => e.CompanyCity)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("公司地址城市");

            builder.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("公司名称");

            builder.Property(e => e.CompanyProvince)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("公司地址省份");

            builder.Property(e => e.ContractWay)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("联系方式");

            builder.Property(e => e.LocationAddress)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("所在地详细地址");

            builder.Property(e => e.LocationArea)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("所在地区县");

            builder.Property(e => e.LocationCity)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("所在地城市");

            builder.Property(e => e.LocationProvince)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("所在地省份");

            builder.Property(e => e.Mobile)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PassWord)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime).HasColumnType("datetime");

            builder.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}