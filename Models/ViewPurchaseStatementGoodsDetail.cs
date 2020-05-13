using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewPurchaseStatementGoodsDetail
    {
        public int PurchaseStatementId { get; set; }
        public int PurchaseId { get; set; }
        public int GoodsId { get; set; }
        public decimal InPrice { get; set; }
        public int Num { get; set; }
        public decimal Amount { get; set; }
        public int ReceivedNum { get; set; }
        public bool IsEmergency { get; set; }
        public int SupplierNum { get; set; }
        public DateTime DelayDate { get; set; }
        public string PurchaseStatus { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseType { get; set; }
        public int SupplierId { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public string InvoiceType { get; set; }
        public decimal TaxRate { get; set; }
        public decimal NoTaxInPrice { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NoTaxAmount { get; set; }
        public string TaxCode { get; set; }
    }
}
