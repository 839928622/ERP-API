using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsModelValue
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int ModelId { get; set; }
        public string Value { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
