using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchAuth
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public int BranchId { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string Token { get; set; }
        public long? ExpiresTime { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
