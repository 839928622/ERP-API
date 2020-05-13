using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class MemberAuth
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public int? BranchId { get; set; }
        public string AccessToken { get; set; }
        public string RereshToken { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string StrustNo { get; set; }
        public int? ExpireTimeSpan { get; set; }
    }
}
