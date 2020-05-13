using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class CatagoryParams
    {
        public int Id { get; set; }
        public string ItypeCode { get; set; }
        public int BranchId { get; set; }
        public int PlatId { get; set; }
        public string ParamsName { get; set; }
        public int UserBy { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
