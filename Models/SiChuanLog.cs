using System;

namespace ERP_API.Models
{
    public partial class SiChuanLog
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string Content { get; set; }
        public int? UserId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
