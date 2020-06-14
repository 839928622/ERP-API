using System;

namespace ERP_API.Models
{
    public partial class SysBranchActivity
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string PhotoPath { get; set; }
        public string Link { get; set; }
        public bool IsEnable { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int? ProductTpn { get; set; }
    }
}
