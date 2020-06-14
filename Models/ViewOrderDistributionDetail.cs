using System;

namespace ERP_API.Models
{
    public partial class ViewOrderDistributionDetail
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int PbranchId { get; set; }
        public int OriginalBranchId { get; set; }
        public double ParentReceiveRate { get; set; }
        public int OrderId { get; set; }
        public int OrderDetailId { get; set; }
        public int GoodsId { get; set; }
        public int OrderDistributionId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public bool IsDelete { get; set; }
        public bool? IsPicked { get; set; }
        public DateTime? PickTime { get; set; }
        public bool? IsPrinted { get; set; }
        public DateTime? PrintTime { get; set; }
        public bool? IsDelivered { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public bool? IsArrived { get; set; }
        public DateTime? ArriveTime { get; set; }
        public DateTime? AllocationTime { get; set; }
        public bool? IsLocked { get; set; }
        public decimal OrgPrice { get; set; }
        public decimal OrgAmount { get; set; }
        public string SingleRemark { get; set; }
        public int DisplayNum { get; set; }
        public string DisplayUnit { get; set; }
        public decimal DisplayPrice { get; set; }
        public decimal GrossProfit { get; set; }
        public string GrossProfitPercent { get; set; }
        public string DisplayName { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public string Unit { get; set; }
    }
}
