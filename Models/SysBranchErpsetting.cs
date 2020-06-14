using System;

namespace ERP_API.Models
{
    public partial class SysBranchErpsetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Erpname { get; set; }
        public string IconUrl { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
