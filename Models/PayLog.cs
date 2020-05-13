using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PayLog
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string LogText { get; set; }
        public string Amount { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
