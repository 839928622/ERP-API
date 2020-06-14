namespace ERP_API.Models
{
    public partial class ViewPickOrderDetail
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
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public string StoreZone { get; set; }
        public int? StoreId { get; set; }
        public int? StoreNum { get; set; }
        public int? InventoryId { get; set; }
        public bool? IsDefault { get; set; }
        public string Name { get; set; }
        public string StoreZoneMemo { get; set; }
        public int? BranchId { get; set; }
    }
}
