using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SystemManager
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string PassWord { get; set; }
        public DateTime AddTime { get; set; }
        public string Role { get; set; }
    }
}
