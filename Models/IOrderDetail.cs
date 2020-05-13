using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IOrderDetail
    {
        public int Id { get; set; }
        public string IOrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
