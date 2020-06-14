﻿using System;

namespace ERP_API.Models
{
    public partial class MemberApplyDept
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MemberId { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
