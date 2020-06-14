using System;

namespace ERP_API.Models
{
    public partial class ViewInvoiceLog
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceRequireId { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceContent { get; set; }
        public DateTime InvoiceCreateTime { get; set; }
        public string InvoiceStatus { get; set; }
        public int OrderStatementId { get; set; }
        public int MemberId { get; set; }
        public string CustomerName { get; set; }
        public decimal InvoiceMoney { get; set; }
        public string InvoiceType { get; set; }
        public string Content { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Memo { get; set; }
        public string DistributionType { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal AllInvoiceMoney { get; set; }
        public string StatementUser { get; set; }
        public string InvoiceCreateUser { get; set; }
        public string InvoiceDeleteUser { get; set; }
        public string InvoiceRequireUser { get; set; }
        public int SalesId { get; set; }
        public string SalesName { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int Credit { get; set; }
        public int CreditDays { get; set; }
        public bool IsRelateDetail { get; set; }
        public int? ReceiveMoneyId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime InvoiceDeleteTime { get; set; }
        public bool? IsPushInvoicePlat { get; set; }
        public string OrderNo { get; set; }
        public string PlatInvoiceRequestNo { get; set; }
        public bool? IsInvoiceSuccess { get; set; }
        public string PdfUrl { get; set; }
        public string InvoiceDetailUrl { get; set; }
        public string CancelPdfUrl { get; set; }
        public string CancelDetailUrl { get; set; }
        public string CancelOrderNo { get; set; }
        public string CancelPlatInvoiceRequestNo { get; set; }
        public string StatementIds { get; set; }
    }
}
