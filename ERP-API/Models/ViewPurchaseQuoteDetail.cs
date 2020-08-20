using System;

namespace ERP_API.Models
{
    public partial class ViewPurchaseQuoteDetail
    {
        public int Id { get; set; }
        public int PurchaseQuoteId { get; set; }
        public int GoodsId { get; set; }
        public int DonvvSku { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public int PurchaseId { get; set; }
        public string DisplayName { get; set; }
    }
}
