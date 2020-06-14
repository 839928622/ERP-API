using System;

namespace ERP_API.Models
{
    public partial class SysGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LeaderBranchId { get; set; }
        public int UserNum { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime AddTime { get; set; }
        public bool? IsDistribuionGroup { get; set; }
    }
}
