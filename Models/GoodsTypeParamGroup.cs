using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsTypeParamGroup
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string ParamSource { get; set; }
        public string GroupName { get; set; }
        public int Sort { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
    }
}
