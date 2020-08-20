using System;

namespace ERP_API.Models
{
    public partial class SysApprove
    {
        public int Id { get; set; }
        public string KeyId { get; set; }
        public string ApproveKey { get; set; }
        public string ApproveAccount { get; set; }
        public int? ApproveMethod { get; set; }
        public int? ApproveType { get; set; }
        public DateTime? ApproveAt { get; set; }
        public string ApproveCode { get; set; }
        public int? ApproveCount { get; set; }
        public int? ApproveLimit { get; set; }
        public bool? ApproveValid { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
