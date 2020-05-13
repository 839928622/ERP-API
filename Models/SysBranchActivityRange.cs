using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchActivityRange
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int ItemType { get; set; }
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
