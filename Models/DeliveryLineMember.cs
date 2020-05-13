using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class DeliveryLineMember
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int LineId { get; set; }
        public int Distance { get; set; }
        public string Remark { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
