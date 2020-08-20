using System;

namespace ERP_API.Models
{
    public partial class Dostatement
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Memo { get; set; }
        public int PrintNum { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceStatus { get; set; }
        public decimal InvoiceMoney { get; set; }
        public int UserId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal InvoiceChargeOff { get; set; }
        public decimal SumGoodsAmount { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal? ApplyReceiveMoney { get; set; }
        public decimal? ApplyInvoiceMoney { get; set; }
    }
}
