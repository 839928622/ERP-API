using System;

namespace ERP_API.Models
{
    public partial class LogisticsCompany
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDisable { get; set; }
        public int SupportedId { get; set; }
    }
}
