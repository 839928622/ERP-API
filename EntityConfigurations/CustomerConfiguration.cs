using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_API.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasIndex(e => new {e.BranchId, e.Name})
                .HasName("IX_Customer")
                .IsUnique();

            builder.HasIndex(e => new
                {
                    e.Id, e.Name, e.Type, e.Status, e.EmployeesNum, e.Telphone, e.SalesId, e.PayMethod, e.CreditDays,
                    e.BranchId, e.PayType
                })
                .HasName("<Name of Missing Index, sysname,>");

            builder.Property(e => e.AddTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Balance).HasColumnType("money");

            builder.Property(e => e.BalanceType).HasDefaultValueSql("((1))");

            builder.Property(e => e.BranchId).HasDefaultValueSql("((1))");

            builder.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ConfirmLevel)
                .HasDefaultValueSql("((5))")
                .HasComment("审核下单level");

            builder.Property(e => e.Credit).HasComment("信用额度");

            builder.Property(e => e.CreditDays).HasComment("账期");

            builder.Property(e => e.EmailForInvoice)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.EmployeesNum)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.EndTime).HasColumnType("datetime");

            builder.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceAddress)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceBank)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceBankAccount)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceCategory)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('纸质发票')");

            builder.Property(e => e.InvoiceContent)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            builder.Property(e => e.InvoiceMemo)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceName)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.InvoicePhone)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceTaxNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.InvoiceType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("增票，普票，收据，无需发票");

            builder.Property(e => e.IsBudget).HasComment("是否启用预算管理");

            builder.Property(e => e.IsBuyOutCounter).HasComment("是否可以买专柜以外的商品");

            builder.Property(e => e.IsComfirmOrder).HasComment("是否启用审核下单");

            builder.Property(e => e.IsCounter).HasComment("是否启用专柜");

            builder.Property(e => e.IsDisable).HasDefaultValueSql("((0))");

            builder.Property(e => e.IsMultiAccount)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("是否启用多账号");

            builder.Property(e => e.IsOrdering).HasComment("1:开启连续下单状态");

            builder.Property(e => e.IsStoreManager).HasComment("是否启用库存管理");

            builder.Property(e => e.Level)
                .HasDefaultValueSql("((3))")
                .HasComment("客户级别：1-5,5最高");

            builder.Property(e => e.Memo).HasMaxLength(1000);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.OrderDiscount)
                .HasDefaultValueSql("((100))")
                .HasComment("默认的折扣，对专柜也有效！");

            builder.Property(e => e.OrderMemo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("开单特殊说明");

            builder.Property(e => e.OrderPrintNum)
                .HasDefaultValueSql("((2))")
                .HasComment("订单打印份数");

            builder.Property(e => e.PayMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("支票，现金，电汇，其它");

            builder.Property(e => e.PayType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("现结，月结");

            builder.Property(e => e.PostCode)
                .HasMaxLength(6)
                .IsUnicode(false);

            builder.Property(e => e.Province)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Py)
                .HasColumnName("PY")
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.RegisterMethod)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.SalesId).HasComment("默认销售员");

            builder.Property(e => e.ServiceId).HasComment("客服");

            builder.Property(e => e.ShortName)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.StartTime).HasColumnType("datetime");

            builder.Property(e => e.StatementManId).HasComment("对账员");

            builder.Property(e => e.StatementMemo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("对账备注");

            builder.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.StoreMemo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("理货特殊说明");

            builder.Property(e => e.Telphone)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Website)
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}