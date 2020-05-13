using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IChengDuParamValue
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int GoodsId { get; set; }
        public int ParamId { get; set; }
        public string Value { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
