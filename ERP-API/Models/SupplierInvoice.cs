using System;

namespace ERP_API.Models
{
    public partial class SupplierInvoice
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
        public decimal InvoiceMoney { get; set; }
        public string Content { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Memo { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
        public string InvoiceCompany { get; set; }
    }
}
