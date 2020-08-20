using System;

namespace ERP_API.Models
{
    public partial class OrderLog
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public string Operate { get; set; }
        public bool IsInner { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
