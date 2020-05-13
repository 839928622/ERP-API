using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrderModifyAc
    {
        public int Id { get; set; }
        public int ModifyAcid { get; set; }
        public int OrderId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal NewGrossProfit { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal OldAc { get; set; }
        public decimal NewAc { get; set; }
        public string OldGrossProfitPercent { get; set; }
        public string NewGrossProfitPercent { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public int BranchId { get; set; }
    }
}
