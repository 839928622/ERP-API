using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IGoodsOperateLog
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ProjectId { get; set; }
        public int GoodsId { get; set; }
        public int OperateType { get; set; }
        public bool IsDel { get; set; }
        public DateTime DtCreate { get; set; }
        public DateTime DtUpdate { get; set; }
    }
}
