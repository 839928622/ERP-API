using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int OrderStatementId { get; set; }
        public int InvoiceRequireId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceType { get; set; }
        public decimal InvoiceMoney { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UserId { get; set; }
        public string InvoiceCode { get; set; }
        public string Content { get; set; }
        public int? ReceiveMoneyId { get; set; }
        public bool? IsPushInvoicePlat { get; set; }
        public string OrderNo { get; set; }
        public string PlatInvoiceRequestNo { get; set; }
        public bool? IsInvoiceSuccess { get; set; }
        public string PdfUrl { get; set; }
        public string InvoiceDetailUrl { get; set; }
        public bool IsRelateDetail { get; set; }
    }
}
