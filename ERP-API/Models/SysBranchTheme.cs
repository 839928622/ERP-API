using System;

namespace ERP_API.Models
{
    public partial class SysBranchTheme
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public bool IsEnable { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
