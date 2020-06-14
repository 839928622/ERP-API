using System;

namespace ERP_API.Models
{
    public partial class CustomerLog
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Category { get; set; }
        public string Operate { get; set; }
        public DateTime AddTime { get; set; }
        public string Tracking { get; set; }
    }
}
