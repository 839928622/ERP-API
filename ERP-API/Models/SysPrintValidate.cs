using System;

namespace ERP_API.Models
{
    public partial class SysPrintValidate
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime? ExpiresTime { get; set; }
        public DateTime AddTime { get; set; }
    }
}
