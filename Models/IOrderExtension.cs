using System;

namespace ERP_API.Models
{
    public partial class IOrderExtension
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int OrderId { get; set; }
        public string AttrName { get; set; }
        public string AttrVal { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
