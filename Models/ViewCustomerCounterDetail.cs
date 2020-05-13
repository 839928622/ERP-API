using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewCustomerCounterDetail
    {
        public int CounterId { get; set; }
        public int CustomerId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UserId { get; set; }
        public int GoodsId { get; set; }
        public decimal Vipprice { get; set; }
        public int Level { get; set; }
        public bool IsSales { get; set; }
        public DateTime AddTime { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
