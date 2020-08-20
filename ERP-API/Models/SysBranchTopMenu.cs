using System;

namespace ERP_API.Models
{
    public partial class SysBranchTopMenu
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool? IsBlank { get; set; }
        public int Sort { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
