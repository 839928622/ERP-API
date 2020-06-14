using System;

namespace ERP_API.Models
{
    public partial class ProGoodsType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public int Level { get; set; }
        public int PointRate { get; set; }
        public string PriceArea { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsLeaf { get; set; }
        public string DefaultUnit { get; set; }
        public string DefaultSource { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Py { get; set; }
        public int BranchId { get; set; }
    }
}
