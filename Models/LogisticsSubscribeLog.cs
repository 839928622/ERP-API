using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class LogisticsSubscribeLog
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public string Context { get; set; }
        public DateTime AddTime { get; set; }
    }
}
