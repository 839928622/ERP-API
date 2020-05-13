using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchThemeArea
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Cols { get; set; }
        public int Rows { get; set; }
        public int RowHeight { get; set; }
        public int ColWidth { get; set; }
        public string Remark { get; set; }
        public int Sort { get; set; }
        public bool IsEnable { get; set; }
        public DateTime UpdateTime { get; set; }
        public int ColSpace { get; set; }
        public int RowSpace { get; set; }
    }
}
