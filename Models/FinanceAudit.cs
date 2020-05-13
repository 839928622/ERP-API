using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class FinanceAudit
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? FinanceId { get; set; }
        public int? UserId { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string Type { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string FinanceData { get; set; }
    }
}
