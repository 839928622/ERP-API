﻿using System;

namespace ERP_API.Models
{
    public partial class ViewSysPermission
    {
        public int Id { get; set; }
        public string ClientType { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public bool IsMenu { get; set; }
        public string Menu { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public int Sort { get; set; }
        public bool IsBlank { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public string GroupName { get; set; }
        public int GroupSort { get; set; }
    }
}
