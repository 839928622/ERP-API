using System;

namespace ERP_API.Models
{
    public partial class ViewSysBranchCss
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CssId { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string CssFileName { get; set; }
        public string Memo { get; set; }
    }
}
