using System;

namespace ERP_API.Models
{
    public partial class ViewPickPurchaseDetail
    {
        public int Id { get; set; }
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
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public int? InventoryId { get; set; }
        public int? StoreId { get; set; }
        public string StoreZone { get; set; }
        public int? StoreNum { get; set; }
        public string Name { get; set; }
        public bool? IsDefault { get; set; }
        public string StoreZoneMemo { get; set; }
        public int? BranchId { get; set; }
        public bool IsCustomGoods { get; set; }
        public int OrderDetailId { get; set; }
        public string DetailMemo { get; set; }
        public bool IIsCustomGoods { get; set; }
        public int IOrderDetailId { get; set; }
    }
}
