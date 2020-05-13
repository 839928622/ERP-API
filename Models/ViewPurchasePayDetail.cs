using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewPurchasePayDetail
    {
        public int Id { get; set; }
        public int PayId { get; set; }
        public int PurchaseId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal InPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal ChargeOffAmount { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public int PurchaseStatementId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal PayMoney { get; set; }
        public string PayType { get; set; }
        public DateTime PayDate { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string UserName { get; set; }
        public int? PayAccountId { get; set; }
        public string PurchaseStatus { get; set; }
        public string PayAccount { get; set; }
    }
}
