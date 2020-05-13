using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IProduct
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ServerId { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string Token { get; set; }
        public long? ExpiredTime { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
