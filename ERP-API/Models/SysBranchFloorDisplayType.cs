using System;

namespace ERP_API.Models
{
    public partial class SysBranchFloorDisplayType
    {
        public int Id { get; set; }
        public int BranchFloorId { get; set; }
        public int DisplayTypeId { get; set; }
        public string DisplayTypeName { get; set; }
        public int GoodsId { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string GoodsName { get; set; }
        public int TypeSort { get; set; }
        public int GoodsSort { get; set; }
    }
}
