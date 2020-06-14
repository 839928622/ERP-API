using System;

namespace ERP_API.Models
{
    public partial class SysBranchAreas
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public int HeaderHeight { get; set; }
        public string HeaderBackGroundColor { get; set; }
        public int HeaderFontSize { get; set; }
        public string HeaderFontColor { get; set; }
        public int Cols { get; set; }
        public int Rows { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool? IsShowHeader { get; set; }
        public int RowHeight { get; set; }
        public int ColWidth { get; set; }
        public int ColSpace { get; set; }
        public int RowSpace { get; set; }
        public int BorderWidth { get; set; }
        public string BorderColor { get; set; }
        public bool? IsEnable { get; set; }
    }
}
