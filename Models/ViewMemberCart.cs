using System;

namespace ERP_API.Models
{
    public partial class ViewMemberCart
    {
        public int MemberId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int MinimumQuantity { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
        public string HomeImage { get; set; }
        public decimal InPrice { get; set; }
        public bool IsEnable { get; set; }
        public bool IsChecked { get; set; }
        public int Multiples { get; set; }
        public int DisplayNum { get; set; }
        public string DisplayUnit { get; set; }
    }
}
