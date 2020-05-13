using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class TransferLog
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public string OperatorName { get; set; }
        public string Status { get; set; }
        public string Operate { get; set; }
        public bool IsInner { get; set; }
        public int OperatorId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
