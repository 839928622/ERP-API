using System;

namespace ERP_API.Models
{
    public partial class InvoiceRequire
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MemberId { get; set; }
        public int StatementId { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceContent { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string InvoiceMemo { get; set; }
        public string InvoiceStatus { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DistributionType { get; set; }
        public bool IsRelateDetail { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string BuyerTaxNum { get; set; }
        public string BuyerBank { get; set; }
        public string BuyerBankAccount { get; set; }
        public string BuyerAddress { get; set; }
        public string SaleName { get; set; }
        public string SaleTaxNum { get; set; }
        public string SaleBank { get; set; }
        public string SaleBankAccount { get; set; }
        public string SalePhone { get; set; }
        public string SaleAddress { get; set; }
        public bool IsCrossInvoice { get; set; }
        public int PreInvoiceId { get; set; }
        public string BuyerPhone { get; set; }
    }
}
