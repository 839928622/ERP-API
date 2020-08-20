using System;

namespace ERP_API.Models
{
    public partial class ViewCustomerLog
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MemberId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CustomerName { get; set; }
        public string MemberName { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
    }
}
