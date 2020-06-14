using System;

namespace ERP_API.Models
{
    public partial class LoginedIdentity
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string BuyerCookie { get; set; }
        public string SessionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string PostUrl { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}
