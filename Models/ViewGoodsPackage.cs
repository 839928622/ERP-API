using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewGoodsPackage
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
        public int BranchId { get; set; }
        public string CombinationType { get; set; }
        public string DonvvSpuCode { get; set; }
        public string DonvvSkuCode { get; set; }
    }
}
