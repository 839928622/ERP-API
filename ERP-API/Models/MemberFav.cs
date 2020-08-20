using System;

namespace ERP_API.Models
{
    public partial class MemberFav
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int GoodsId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
