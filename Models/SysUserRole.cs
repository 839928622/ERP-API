using System;

namespace ERP_API.Models
{
    public partial class SysUserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
