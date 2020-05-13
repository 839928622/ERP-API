using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewSysUsers
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int DeptId { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Idcard { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Position { get; set; }
        public string Token { get; set; }
        public DateTime? TokenEndDate { get; set; }
        public string DingId { get; set; }
        public string BranchName { get; set; }
        public string DeptName { get; set; }
        public bool IsValid { get; set; }
        public bool IsSales { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsYinLi { get; set; }
    }
}
