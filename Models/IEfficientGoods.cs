using System;

namespace ERP_API.Models
{
    public partial class IEfficientGoods
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int IprojectId { get; set; }
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public string Model { get; set; }
        public string EfficientGoodsCardNum { get; set; }
        public string EfficientGoodsImagePath { get; set; }
        public string EfficientGoodsCardOrgan { get; set; }
        public DateTime AddAt { get; set; }
        public string AddBy { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
