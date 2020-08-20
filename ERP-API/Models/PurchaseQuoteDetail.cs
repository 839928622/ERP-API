using System;

namespace ERP_API.Models
{
    public partial class PurchaseQuoteDetail
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
    }
}
