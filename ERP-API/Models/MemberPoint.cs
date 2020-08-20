using System;

namespace ERP_API.Models
{
    public partial class MemberPoint
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Type { get; set; }
        public int RelationId { get; set; }
        public decimal Income { get; set; }
        public decimal Spend { get; set; }
        public decimal Balance { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
