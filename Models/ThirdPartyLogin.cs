using System;

namespace ERP_API.Models
{
    public partial class ThirdPartyLogin
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public string Uuid { get; set; }
        public string Type { get; set; }
        public int? BranchId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
