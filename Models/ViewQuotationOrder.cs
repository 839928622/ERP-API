using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewQuotationOrder
    {
        public int OrderId { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime QuotationTime { get; set; }
        public DateTime ValidTime { get; set; }
        public int ValidDay { get; set; }
        public bool QuotationIsDelete { get; set; }
        public int BranchId { get; set; }
        public string Guid { get; set; }
        public int? DeptId { get; set; }
        public int? MemberId { get; set; }
        public string OrderType { get; set; }
        public DateTime? OrderTime { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal? SumMoney { get; set; }
        public decimal? GrossProfit { get; set; }
        public decimal? Point { get; set; }
        public string Customer { get; set; }
        public string DeptName { get; set; }
        public string RealName { get; set; }
        public string Telphone { get; set; }
        public string Address { get; set; }
        public string Memo { get; set; }
        public string InvoiceType { get; set; }
        public int? SaveNum { get; set; }
        public string PayStatus { get; set; }
        public string PayType { get; set; }
        public bool? IsEnable { get; set; }
        public bool? IsEmergency { get; set; }
        public bool? IsInner { get; set; }
        public bool? OrderIsDelete { get; set; }
        public bool? IsStorage { get; set; }
        public bool? IsCopied { get; set; }
        public int? RawOrderId { get; set; }
        public int? UserId { get; set; }
        public int? SalesId { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceStatus { get; set; }
        public DateTime? ServiceFinishTime { get; set; }
        public string PurchaseStatus { get; set; }
        public DateTime? PurchaseFinishTime { get; set; }
        public string StoreStatus { get; set; }
        public int? PackageNum { get; set; }
        public string DeliveryStatus { get; set; }
        public bool? IsArchive { get; set; }
        public int? ApplyId { get; set; }
        public string IOrderId { get; set; }
        public string IName { get; set; }
        public decimal? ChargeOff { get; set; }
        public bool? IsChecked { get; set; }
        public string DeliveryType { get; set; }
        public int? RawBranchId { get; set; }
        public bool? GroupChecked { get; set; }
        public string InvoiceCategory { get; set; }
        public string EmailForInvoice { get; set; }
        public string InvoiceInfo { get; set; }
        public bool? IsConfirm { get; set; }
        public string ConfirmStatus { get; set; }
        public DateTime? ConfirmFinishTime { get; set; }
        public bool? IsShowAmountInPrint { get; set; }
        public string QuotationStatus { get; set; }
        public string PaymentType { get; set; }
        public int? LogisticsId { get; set; }
        public double? GroupReceivePercent { get; set; }
        public int? RowNum { get; set; }
        public string SalesName { get; set; }
    }
}
