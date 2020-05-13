using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysDistribution
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int BranchId { get; set; }
        public int PbranchId { get; set; }
        public int TopBranchId { get; set; }
        public int Level { get; set; }
        public DateTime AddTime { get; set; }
        public double ParentReceiveRate { get; set; }
    }
}
