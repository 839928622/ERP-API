using System;

namespace ERP_API.Models
{
    public partial class SysSms
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Mobile { get; set; }
        public int Smscode { get; set; }
        public string Content { get; set; }
        public int? Status { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int UserId { get; set; }
    }
}
