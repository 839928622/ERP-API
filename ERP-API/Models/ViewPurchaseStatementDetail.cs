using System;

namespace ERP_API.Models
{
    public partial class ViewPurchaseStatementDetail
    {
        public int PurchaseStatementId { get; set; }
        public int PurchaseId { get; set; }
        public int BranchId { get; set; }
        public int StoreId { get; set; }
        public int NeedToPurchaseId { get; set; }
        public int SupplierId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseType { get; set; }
        public decimal SumMoney { get; set; }
        public string Status { get; set; }
        public string SupplierStatus { get; set; }
        public bool IsChecked { get; set; }
        public string PayStatus { get; set; }
        public string Memo { get; set; }
        public int ReceiptUserId { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal TaxMoney { get; set; }
        public decimal NoTaxMoney { get; set; }
    }
}
