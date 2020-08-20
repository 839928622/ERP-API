using System;

namespace ERP_API.Models
{
    public partial class GoodsPriceLog : BaseEntity
    {
     
        public int GoodsId { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
