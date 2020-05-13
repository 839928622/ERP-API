﻿using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Ac { get; set; }
        public decimal Amount { get; set; }
        public decimal Point { get; set; }
        public string PurchaseMemo { get; set; }
        public int PickNum { get; set; }
        public bool IsGift { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public string HomeImage { get; set; }
        public decimal GoodsPrice { get; set; }
        public int MinimumQuantity { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int DeptId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime PlanDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsEnable { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsInner { get; set; }
        public bool IsDelete { get; set; }
        public bool IsStorage { get; set; }
        public bool IsCopied { get; set; }
        public int RawOrderId { get; set; }
        public string ServiceStatus { get; set; }
        public string PurchaseStatus { get; set; }
        public string StoreStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public string DeptName { get; set; }
        public string RealName { get; set; }
        public string Telphone { get; set; }
        public int? StoreId { get; set; }
        public string StoreName { get; set; }
        public string Model { get; set; }
        public int SaleNumber { get; set; }
        public int SaleCount { get; set; }
        public int StockNum { get; set; }
        public string Sn { get; set; }
        public string Customer { get; set; }
        public string CustomerShortName { get; set; }
        public decimal SumMoney { get; set; }
        public decimal OrderAmount { get; set; }
        public string SingleRemark { get; set; }
        public string InternalRemark { get; set; }
        public string IOrderId { get; set; }
        public string OrderType { get; set; }
        public DateTime StoreFinishTime { get; set; }
        public bool IsTotalPriceModel { get; set; }
        public bool IsConfirm { get; set; }
        public string Address { get; set; }
        public string Memo { get; set; }
        public int SalesId { get; set; }
        public string SalesName { get; set; }
        public bool IsCustomGoods { get; set; }
        public bool AntiCounterfeiting { get; set; }
        public int DisplayNum { get; set; }
        public string DisplayUnit { get; set; }
        public bool IsComment { get; set; }
        public decimal DisplayPrice { get; set; }
        public DateTime? DeliveryFinishTime { get; set; }
        public int OldOrderId { get; set; }
        public int RefundNum { get; set; }
        public string GrossProfitPercent { get; set; }
        public decimal Afc { get; set; }
        public DateTime? PurchaseFinishTime { get; set; }
        public decimal GrossProfit { get; set; }
        public bool Checkout { get; set; }
        public decimal TaxMoney { get; set; }
        public decimal NoTaxMoney { get; set; }
        public decimal OrderGrossProfitPercent { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NoTaxAmount { get; set; }
        public decimal DetailGrossProfit { get; set; }
        public decimal NoTaxPrice { get; set; }
        public decimal DisplayNoTaxPrice { get; set; }
        public string Tpn { get; set; }
        public string LoginName { get; set; }
    }
}
