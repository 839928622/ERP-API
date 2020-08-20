using System;

namespace ERP_API.Models
{
    public partial class MemberRole
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int RoleId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
