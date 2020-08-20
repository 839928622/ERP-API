using System;

namespace ERP_API.Models
{
    public partial class SysAuthorize
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public DateTime OldExpiredDate { get; set; }
        public int AuthorizeYear { get; set; }
        public DateTime NewExpiredDate { get; set; }
        public int OldUserNum { get; set; }
        public int AuthorizeNum { get; set; }
        public int NewUserNum { get; set; }
        public decimal Money { get; set; }
        public string PayStatus { get; set; }
        public int SysUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
