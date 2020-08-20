using System;

namespace ERP_API.Models
{
    public partial class GoodsTypePrivateInfo : BaseEntity
    {
        public int TypeId { get; set; }
        public string Alias { get; set; }
        public int Sort { get; set; }
        public bool IsDisable { get; set; }
        public int PointRate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
