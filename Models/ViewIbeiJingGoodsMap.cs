using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewIbeiJingGoodsMap
    {
        public string Expr1 { get; set; }
        public int Id { get; set; }
        public string IProductId { get; set; }
        public string ICategory { get; set; }
        public string IBrand { get; set; }
        public string IProductName { get; set; }
        public decimal? ISalePrice { get; set; }
        public int? DonvvGoodsId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? BranchId { get; set; }
    }
}
