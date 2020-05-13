using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class InvoiceLog
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
        public string InvoiceCode { get; set; }
        public string Content { get; set; }
        public int? ReceiveMoneyId { get; set; }
        public bool? IsPushInvoicePlat { get; set; }
        public string OrderNo { get; set; }
        public string PlatInvoiceRequestNo { get; set; }
        public bool? IsInvoiceSuccess { get; set; }
        public string PdfUrl { get; set; }
        public string InvoiceDetailUrl { get; set; }
        public DateTime InvoiceCreateTime { get; set; }
        public int InvoiceCreateUserId { get; set; }
        public DateTime InvoiceDeleteTime { get; set; }
        public int InvoiceDeleteUserId { get; set; }
        public string CancelPdfUrl { get; set; }
        public string CancelDetailUrl { get; set; }
        public string CancelOrderNo { get; set; }
        public string CancelPlatInvoiceRequestNo { get; set; }
        public string StatementIds { get; set; }
    }
}
