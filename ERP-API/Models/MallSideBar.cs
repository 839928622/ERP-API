using System;

namespace ERP_API.Models
{
    public partial class MallSideBar
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string HoverName { get; set; }
        public string Icon { get; set; }
        public bool IsEnable { get; set; }
    }
}
