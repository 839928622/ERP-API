using System;

namespace ERP_API.Models
{
    public partial class ModifyAc
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int GoodsId { get; set; }
        public string Unit { get; set; }
        public decimal OldInPrice { get; set; }
        public decimal OldAc { get; set; }
        public bool ModifyGoodsInPrice { get; set; }
        public decimal NewInPrice { get; set; }
        public bool ModifyInventoryAc { get; set; }
        public int StockNum { get; set; }
        public int ModifyOrderDetailAc { get; set; }
        public int OrderCount { get; set; }
        public decimal NewAc { get; set; }
        public int UserId { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
