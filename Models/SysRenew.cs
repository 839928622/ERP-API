using System;

namespace ERP_API.Models
{
    public partial class SysRenew
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Type { get; set; }
        public int AcountNum { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Money { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
