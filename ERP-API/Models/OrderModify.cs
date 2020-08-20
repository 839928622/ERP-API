using System;

namespace ERP_API.Models
{
    public partial class OrderModify
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int OldNum { get; set; }
        public int NewNum { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string PurchaseType { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsNeedCollect { get; set; }
        public int NeedToPurchaseId { get; set; }
        public string DisplayUnit { get; set; }
        public string Memo { get; set; }
        public decimal OldTaxRate { get; set; }
        public decimal NewTaxRate { get; set; }
    }
}
