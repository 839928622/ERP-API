using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IBeiJingGoods
    {
        public int Id { get; set; }
        public string IProductId { get; set; }
        public string ICategory { get; set; }
        public string IBrand { get; set; }
        public string IProductName { get; set; }
        public decimal? ISalePrice { get; set; }
    }
}
