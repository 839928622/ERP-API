using System;

namespace ERP_API.Models
{
    public partial class IGoods
    {
        public int Id { get; set; }
        public int IProjectId { get; set; }
        public int GoodsId { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int Num { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsEnable { get; set; }
        public decimal Discount { get; set; }
        public decimal? MarketPrice { get; set; }
        public bool? IsModify { get; set; }
        public int? StockNum { get; set; }
        public bool? IsNeededPush { get; set; }
    }
}
