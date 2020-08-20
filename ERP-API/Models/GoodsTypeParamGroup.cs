using System;

namespace ERP_API.Models
{
    public partial class GoodsTypeParamGroup : BaseEntity
    {
        public int TypeId { get; set; }
        public string ParamSource { get; set; }
        public string GroupName { get; set; }
        public int Sort { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
