using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ProductInfo
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public bool IsChecked { get; set; }
        public string Params { get; set; }
        public DateTime UpdateTime { get; set; }
        public string SourceUrl { get; set; }
    }
}
