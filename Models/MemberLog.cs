using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class MemberLog
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int Operate { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Tracking { get; set; }
        public string CustomerName { get; set; }
    }
}
