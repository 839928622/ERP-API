using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PurchaseDetail
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int GoodsId { get; set; }
        public decimal BillsPrice { get; set; }
        public decimal InPrice { get; set; }
        public int Num { get; set; }
        public decimal Amount { get; set; }
        public int ReceivedNum { get; set; }
        public bool IsEmergency { get; set; }
        public int SupplierNum { get; set; }
        public DateTime DelayDate { get; set; }
        public string PurchaseStatus { get; set; }
        public string DetailMemo { get; set; }
        public bool IsCustomGoods { get; set; }
        public int OrderDetailId { get; set; }
        public int OldPurchaseId { get; set; }
        public bool? IsDonvvSupply { get; set; }
        public string DonvvBrandId { get; set; }
        public string DonvvBrandName { get; set; }
        public bool IsGift { get; set; }
        public int RefundNum { get; set; }
        public string InvoiceType { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NoTaxAmount { get; set; }
        public decimal NoTaxInPrice { get; set; }
        public bool IsTotalAmount { get; set; }
    }
}
