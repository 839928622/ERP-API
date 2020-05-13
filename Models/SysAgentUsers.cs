using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysAgentUsers
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string PassWord { get; set; }
        public string Telphone { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
