using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class Purchase
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int StoreId { get; set; }
        public int NeedToPurchaseId { get; set; }
        public int SupplierId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseType { get; set; }
        public decimal SumMoney { get; set; }
        public string Status { get; set; }
        public string SupplierStatus { get; set; }
        public bool IsChecked { get; set; }
        public string PayStatus { get; set; }
        public string Memo { get; set; }
        public int ReceiptUserId { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal ChargeOff { get; set; }
        public DateTime PutInStoreTime { get; set; }
        public int SaveNum { get; set; }
        public string Remark { get; set; }
        public bool IsDelete { get; set; }
        public bool IsMerge { get; set; }
        public bool IsBrandPurchase { get; set; }
        public int AddUserId { get; set; }
        public int? OrderId { get; set; }
        public decimal TaxMoney { get; set; }
        public decimal NoTaxMoney { get; set; }
        public DateTime? EstimateRecieveDate { get; set; }
    }
}
