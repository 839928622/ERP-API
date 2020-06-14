using System;

namespace ERP_API.Models
{
    public partial class SysBranchServicePromise
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int Sort { get; set; }
        public int Cols { get; set; }
        public int ColWidth { get; set; }
        public int Rows { get; set; }
        public int RowHeight { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
