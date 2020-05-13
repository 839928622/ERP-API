using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class TransferBox
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int BoxId { get; set; }
        public int PrintNum { get; set; }
        public DateTime PrintTime { get; set; }
        public string Status { get; set; }
        public string StoreZone { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
