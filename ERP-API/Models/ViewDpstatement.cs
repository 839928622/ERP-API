using System;

namespace ERP_API.Models
{
    public partial class ViewDpstatement
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public decimal SumMoney { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public decimal InvoiceMoney { get; set; }
        public string InvoiceStatus { get; set; }
        public string Memo { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateByName { get; set; }
        public decimal PaidApplyMoney { get; set; }
        public decimal InvoiceApplyMoney { get; set; }
        public decimal InvoiceChargeOff { get; set; }
    }
}
