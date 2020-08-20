using System;

namespace ERP_API.Models
{
    public partial class ViewOrderPicking
    {
        public int OrderId { get; set; }
        public int PickingUserId { get; set; }
        public int DistributeUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int DeptId { get; set; }
        public int MemberId { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime PlanDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int RowNum { get; set; }
        public decimal SumMoney { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal Point { get; set; }
        public string Customer { get; set; }
        public string DeptName { get; set; }
        public string RealName { get; set; }
        public string Address { get; set; }
        public int PrintNum { get; set; }
        public DateTime PrintTime { get; set; }
        public bool IsEnable { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsInner { get; set; }
        public bool IsDelete { get; set; }
        public bool IsCopied { get; set; }
        public int RawOrderId { get; set; }
        public int Id { get; set; }
        public string StoreStatus { get; set; }
        public string ServiceStatus { get; set; }
        public string PurchaseStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public int PackageNum { get; set; }
        public string Telphone { get; set; }
        public string Memo { get; set; }
        public string Guid { get; set; }
        public string Mobile { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsShowAmountInPrint { get; set; }
        public int SalesId { get; set; }
        public string SalesName { get; set; }
        public int? StoreId { get; set; }
        public string StoreName { get; set; }
        public string ThirdPartyId { get; set; }
    }
}
