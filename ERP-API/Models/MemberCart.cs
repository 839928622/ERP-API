using System;

namespace ERP_API.Models
{
    public partial class MemberCart
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsEnable { get; set; }
        public bool IsChecked { get; set; }
        public int Multiples { get; set; }
        public int DisplayNum { get; set; }
        public string DisplayUnit { get; set; }
    }
}
