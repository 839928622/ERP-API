using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class Logistics
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int OrderId { get; set; }
        public string LogisticName { get; set; }
        public string LogisticNo { get; set; }
        public DateTime? AddAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
