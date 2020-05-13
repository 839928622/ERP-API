using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewMemberOrders
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int DeptId { get; set; }
        public int MemberId { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime PlanDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public int RowNum { get; set; }
        public decimal SumMoney { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal Point { get; set; }
        public string Customer { get; set; }
        public string DeptName { get; set; }
        public string RealName { get; set; }
        public string Telphone { get; set; }
        public string Address { get; set; }
        public string Memo { get; set; }
        public int IsInvoice { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceContent { get; set; }
        public int SaveNum { get; set; }
        public int PrintNum { get; set; }
        public DateTime PrintTime { get; set; }
        public string PayType { get; set; }
        public string PayStatus { get; set; }
        public bool IsEnable { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsInner { get; set; }
        public bool IsDelete { get; set; }
        public bool IsStorage { get; set; }
        public bool IsCopied { get; set; }
        public int RawOrderId { get; set; }
        public int UserId { get; set; }
        public int SalesId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceStatus { get; set; }
        public DateTime? ServiceFinishTime { get; set; }
        public string PurchaseStatus { get; set; }
        public DateTime? PurchaseFinishTime { get; set; }
        public string StoreStatus { get; set; }
        public DateTime StoreFinishTime { get; set; }
        public int PackageNum { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime? DeliveryFinishTime { get; set; }
        public string DeliveryType { get; set; }
        public bool IsArchive { get; set; }
        public int ApplyId { get; set; }
        public string IOrderId { get; set; }
        public string IName { get; set; }
        public decimal ChargeOff { get; set; }
        public bool IsChecked { get; set; }
        public int RawBranchId { get; set; }
        public bool GroupChecked { get; set; }
        public string MemberName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public string PaymentType { get; set; }
    }
}
