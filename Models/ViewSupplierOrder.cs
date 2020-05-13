using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewSupplierOrder
    {
        public string BranchName { get; set; }
        public string ShortName { get; set; }
        public int BranchId { get; set; }
        public int PurchaseId { get; set; }
        public int StoreId { get; set; }
        public int NeedToPurchaseId { get; set; }
        public int SupplierId { get; set; }
        public string PurchaseType { get; set; }
        public decimal SumMoney { get; set; }
        public string Status { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PayStatus { get; set; }
        public string Memo { get; set; }
        public int ReceiptUserId { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string SupplierStatus { get; set; }
        public string UserName { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
    }
}
