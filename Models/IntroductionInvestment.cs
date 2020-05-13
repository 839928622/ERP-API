using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IntroductionInvestment
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
        public int BranchId { get; set; }
    }
}
