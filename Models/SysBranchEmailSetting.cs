using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchEmailSetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Smtpserver { get; set; }
        public bool IsEnableSsl { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public bool IsCheck { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
