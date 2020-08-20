using System;

namespace ERP_API.Models
{
    public partial class SysDistributionGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TopBranchId { get; set; }
        public DateTime AddTime { get; set; }
    }
}
