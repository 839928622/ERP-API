using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ProductGoodsType
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int TypeId { get; set; }
        public int DonvvTypeId { get; set; }
        public string DonvvTypeName { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
