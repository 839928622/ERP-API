using System;

namespace ERP_API.Models
{
    public partial class SupplierInvoiceDetails
    {
        public int Id { get; set; }
        public int SupplierInvoiceId { get; set; }
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int GoodsId { get; set; }
        public string DisplayName { get; set; }
        public decimal? InPrice { get; set; }
        public int Num { get; set; }
        public decimal? Amount { get; set; }
        public DateTime AddTime { get; set; }
        public int InvoicedNum { get; set; }
        public decimal? ToInvoiceMoney { get; set; }
        public int BranchId { get; set; }
        public bool IsDelete { get; set; }
    }
}
