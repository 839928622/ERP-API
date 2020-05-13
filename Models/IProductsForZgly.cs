using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IProductsForZgly
    {
        public int Id { get; set; }
        public string IproductName { get; set; }
        public string Isku { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
