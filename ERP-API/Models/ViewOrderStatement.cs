using System;

namespace ERP_API.Models
{
    public partial class ViewOrderStatement
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public bool IsCrossInvoice { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Memo { get; set; }
        public int PrintNum { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceStatus { get; set; }
        public decimal InvoiceMoney { get; set; }
        public decimal NeedToInvoice { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UserName { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public int BranchId { get; set; }
        public string CustomerName { get; set; }
        public string ShortName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string InvoiceMemo { get; set; }
        public string InvoiceContent { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal SumGoodsAmount { get; set; }
    }
}
