using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IProject
    {
        public int Id { get; set; }
        public int IPlatId { get; set; }
        public int BranchId { get; set; }
        public int ServerId { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string AccessToken { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public string ClientId { get; set; }
        public string PrivateKey { get; set; }
    }
}
