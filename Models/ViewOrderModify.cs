using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrderModify
    {
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int OldNum { get; set; }
        public int NewNum { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Telphone { get; set; }
        public int Id { get; set; }
        public string DisplayUnit { get; set; }
        public string Memo { get; set; }
        public decimal OldTaxRate { get; set; }
        public decimal NewTaxRate { get; set; }
    }
}
