using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IGoodsPart
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ProjectId { get; set; }
        public int GoodsId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
