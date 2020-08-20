using System;

namespace ERP_API.Models
{
    public partial class MajorParamsDetail
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int BranchId { get; set; }
        public int PlatId { get; set; }
        public string ParamsName { get; set; }
        public string ParamsValue { get; set; }
        public int UserBy { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
