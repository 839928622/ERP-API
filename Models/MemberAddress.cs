using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class MemberAddress
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string RealName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string TelPhone { get; set; }
        public string Email { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDelete { get; set; }
    }
}
