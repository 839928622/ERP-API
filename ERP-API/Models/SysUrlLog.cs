using System;

namespace ERP_API.Models
{
    public partial class SysUrlLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Ip { get; set; }
        public string Url { get; set; }
        public string Memo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
