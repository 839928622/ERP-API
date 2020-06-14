using System;

namespace ERP_API.Models
{
    public partial class IGoodsLog
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int IProjectId { get; set; }
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int Num { get; set; }
        public bool IsEnable { get; set; }
        public decimal Discount { get; set; }
        public decimal? MarketPrice { get; set; }
        public string Operate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime OperateTime { get; set; }
        public string Memo { get; set; }
    }
}
