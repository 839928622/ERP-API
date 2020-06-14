using System;

namespace ERP_API.Models
{
    public partial class SysRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
