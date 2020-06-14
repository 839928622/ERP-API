using System;

namespace ERP_API.Models
{
    public partial class SysMapiServer
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerUrl { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string Token { get; set; }
        public DateTime? ExpiresTime { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
