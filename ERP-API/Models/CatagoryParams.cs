using System;

namespace ERP_API.Models
{
    public partial class CatagoryParams : BaseEntity
    {
        public string ItypeCode { get; set; }
        public int PlatId { get; set; }
        public string ParamsName { get; set; }
        public int UserBy { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
