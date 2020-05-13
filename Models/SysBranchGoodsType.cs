using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchGoodsType
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int TypeId { get; set; }
        public bool? IsFloor { get; set; }
        public int Sort { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
