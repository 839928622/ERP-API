using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysPrice
    {
        public int Id { get; set; }
        public int Pirce { get; set; }
        public int StartNum { get; set; }
        public int StartAmount { get; set; }
        public string Memo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
