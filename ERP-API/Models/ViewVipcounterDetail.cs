using System;

namespace ERP_API.Models
{
    public partial class ViewVipcounterDetail
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public int CounterId { get; set; }
        public int GoodsId { get; set; }
        public decimal Vipprice { get; set; }
        public int Level { get; set; }
        public bool IsSales { get; set; }
        public DateTime AddTime { get; set; }
        public string GoodsName { get; set; }
        public decimal Price { get; set; }
        public string DisplayName { get; set; }
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public string TypeName { get; set; }
        public int GoodsTypeLevel { get; set; }
        public bool IsEnable { get; set; }
        public string Unit { get; set; }
        public string HomeImage { get; set; }
        public int StockNum { get; set; }
        public bool IsWeb { get; set; }
    }
}
