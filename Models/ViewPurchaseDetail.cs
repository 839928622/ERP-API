using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewPurchaseDetail
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
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public decimal? Price { get; set; }
        public bool? IsEnable { get; set; }
        public bool? IsWeb { get; set; }
        public int? SaleNumber { get; set; }
        public int? SaleCount { get; set; }
        public int? StockNum { get; set; }
        public int SupplierId { get; set; }
        public int NeedToPurchaseId { get; set; }
        public int BranchId { get; set; }
        public string SupplierStatus { get; set; }
        public bool IsChecked { get; set; }
        public string PayStatus { get; set; }
        public decimal ChargeOff { get; set; }
        public int ReceiptUserId { get; set; }
        public string Status { get; set; }
        public decimal SumMoney { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseType { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int StoreId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierShortName { get; set; }
        public string LinkMan { get; set; }
        public string TelPhone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Memo { get; set; }
        public string DetailMemo { get; set; }
        public string PurchaseName { get; set; }
        public int UserId { get; set; }
        public DateTime PutInStoreTime { get; set; }
        public bool IsCustomGoods { get; set; }
        public int OrderDetailId { get; set; }
        public bool IsDelete { get; set; }
        public bool IsMerge { get; set; }
        public int OldPurchaseId { get; set; }
        public bool? IsDonvvSupply { get; set; }
        public string DonvvBrandName { get; set; }
        public int? DonvvSku { get; set; }
        public string Sn { get; set; }
        public string DonvvBrandId { get; set; }
        public bool IsGift { get; set; }
        public int AddUserId { get; set; }
        public string AddUserName { get; set; }
        public int RefundNum { get; set; }
        public int? OrderId { get; set; }
        public string InvoiceType { get; set; }
        public decimal TaxRate { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public decimal TaxMoney { get; set; }
        public decimal NoTaxMoney { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NoTaxAmount { get; set; }
        public decimal NoTaxInPrice { get; set; }
        public bool IsTotalAmount { get; set; }
    }
}
