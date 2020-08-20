using System;

namespace ERP_API.Models
{
    public partial class SupplierSettleAccounts
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public DateTime LastTimeSadate { get; set; }
        public DateTime SettleAccountDate { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal PurchasePayAmount { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal LastTimeBalance { get; set; }
        public decimal Balance { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
