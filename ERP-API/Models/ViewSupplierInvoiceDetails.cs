using System;

namespace ERP_API.Models
{
    public partial class ViewSupplierInvoiceDetails
    {
        public int Id { get; set; }
        public int SupplierInvoiceId { get; set; }
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string InvoiceType { get; set; }
        public int GoodsId { get; set; }
        public string DisplayName { get; set; }
        public decimal? InPrice { get; set; }
        public DateTime AddTime { get; set; }
        public int InvoicedNum { get; set; }
        public decimal? ToInvoiceMoney { get; set; }
        public int BranchId { get; set; }
        public bool IsDelete { get; set; }
        public string Unit { get; set; }
        public string PurchaseStatus { get; set; }
        public string Status { get; set; }
        public DateTime PutInStoreTime { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
    }
}
