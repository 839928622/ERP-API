using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class StrategyGrossProfit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Term { get; set; }
        public int Way { get; set; }
        public bool IsEnabled { get; set; }
        public int? Extend1 { get; set; }
        public string Extend2 { get; set; }
        public DateTime CreationTime { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public int? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int? DeleterUserId { get; set; }
        public string Remark { get; set; }
        public int Tenant { get; set; }
        public int Privilege { get; set; }
    }
}
