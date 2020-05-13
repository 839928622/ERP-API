using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewInventoryModifyAc
    {
        public int Id { get; set; }
        public int ModifyAcid { get; set; }
        public int StoreId { get; set; }
        public string StoreZone { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal OldAc { get; set; }
        public decimal NewAc { get; set; }
        public string StoreZoneMemo { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public string StoreName { get; set; }
        public int BranchId { get; set; }
    }
}
