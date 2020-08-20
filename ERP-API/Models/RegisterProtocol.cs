using System;

namespace ERP_API.Models
{
    public partial class RegisterProtocol
    {
        public int Id { get; set; }
        public string ProtocolContent { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string ProtocolName { get; set; }
    }
}
