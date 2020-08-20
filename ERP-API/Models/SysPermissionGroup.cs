using System;

namespace ERP_API.Models
{
    public partial class SysPermissionGroup
    {
        public int Id { get; set; }
        public string ClientType { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
