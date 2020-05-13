using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewIgoods
    {
        public int Id { get; set; }
        public int IProjectId { get; set; }
        public int GoodsId { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int Num { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsEnable { get; set; }
        public int BranchId { get; set; }
        public string DisplayName { get; set; }
        public decimal Discount { get; set; }
        public int TypeId { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public decimal Weight { get; set; }
        public string HomeImage { get; set; }
        public bool GoodsEnable { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public bool? IsNeededPush { get; set; }
        public string GoodsTypeName { get; set; }
        public string Model { get; set; }
        public bool IsWeb { get; set; }
        public decimal? MarketPrice { get; set; }
        public bool? IsModify { get; set; }
        public int? StockNum { get; set; }
        public string OperateUser { get; set; }
        public DateTime OperateTime { get; set; }
    }
}
