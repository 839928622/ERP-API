namespace ERP_API.Models
{
    public partial class ViewUserRole
    {
        public string RoleName { get; set; }
        public string GroupName { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int BranchId { get; set; }
        public int DeptId { get; set; }
        public string Mobile { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsValid { get; set; }
        public bool IsSales { get; set; }
    }
}
