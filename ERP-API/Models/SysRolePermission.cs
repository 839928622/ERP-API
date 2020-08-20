using System;

namespace ERP_API.Models
{
    public partial class SysRolePermission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
