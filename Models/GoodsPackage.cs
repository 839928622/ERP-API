using System;

namespace ERP_API.Models
{
    public partial class GoodsPackage
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string Type { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
        public int IsDefault { get; set; }
        public string BarCode { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceExtend { get; set; }
        public string DonvvSpuCode { get; set; }
        public string DonvvSkuCode { get; set; }
    }
}
