using System;

namespace ERP_API.Models
{
    public partial class Dpstatement : BaseEntity
    {
       
        public int SupplierId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public decimal ChargeOff { get; set; }
        public string Memo { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public decimal InvoiceMoney { get; set; }
        public string InvoiceStatus { get; set; }
        public decimal PaidApplyMoney { get; set; }
        public decimal InvoiceApplyMoney { get; set; }
        public decimal InvoiceChargeOff { get; set; }
    }
}
