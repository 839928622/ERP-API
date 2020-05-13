﻿using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewMember
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DeptId { get; set; }
        public string LoginName { get; set; }
        public string PassWord { get; set; }
        public string RealName { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Im { get; set; }
        public int LoginNumber { get; set; }
        public double Point { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string RegisterMethod { get; set; }
        public DateTime RegisterDate { get; set; }
        public int ConfirmLevel { get; set; }
        public int VipcounterLevel { get; set; }
        public bool IsMainContact { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsOrderAuthority { get; set; }
        public bool IsEnable { get; set; }
        public bool IsCheckMobile { get; set; }
        public bool IsCheckEmail { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public string Role { get; set; }
        public string CustomerName { get; set; }
        public string ShortName { get; set; }
        public string DeptName { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public int? Level { get; set; }
        public bool IsForbidden { get; set; }
        public bool IsDerectApply { get; set; }
    }
}
