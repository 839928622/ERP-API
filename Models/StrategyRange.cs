using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class StrategyRange
    {
        public int Id { get; set; }
        public int StrategyId { get; set; }
        public int Type { get; set; }
        public int Mode { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? Extend1 { get; set; }
        public string Extend2 { get; set; }
        public int Category { get; set; }
    }
}
