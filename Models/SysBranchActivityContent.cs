using System;

namespace ERP_API.Models
{
    public partial class SysBranchActivityContent
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int Type { get; set; }
        public string Url { get; set; }
        public int Sort { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
