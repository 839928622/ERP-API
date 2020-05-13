using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ServiceOrderDetail
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int? OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? GoodsId { get; set; }
        public string GoodsName { get; set; }
        public int Num { get; set; }
        public string Remark { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
