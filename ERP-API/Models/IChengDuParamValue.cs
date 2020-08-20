using System;

namespace ERP_API.Models
{
    public partial class IChengDuParamValue : BaseEntity
    {
        public int GoodsId { get; set; }
        public int ParamId { get; set; }
        public string Value { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
