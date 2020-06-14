using System;

namespace ERP_API.Models
{
    public partial class Vipcounter
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int GoodsNum { get; set; }
        public int CustomerNum { get; set; }
    }
}
