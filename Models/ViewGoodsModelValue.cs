using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewGoodsModelValue
    {
        public int GoodsId { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public string Value { get; set; }
        public int BranchId { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public string Sn { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int ParentId { get; set; }
        public int Id { get; set; }
        public bool IsEnable { get; set; }
        public bool IsWeb { get; set; }
    }
}
