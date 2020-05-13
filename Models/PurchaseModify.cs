using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PurchaseModify
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int GoodsId { get; set; }
        public int OldNum { get; set; }
        public int NewNum { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Memo { get; set; }
        public decimal OldTaxRate { get; set; }
        public decimal NewTaxRate { get; set; }
        public decimal OldNoTaxPrice { get; set; }
        public decimal NewNoTaxPrice { get; set; }
    }
}
