using System;

namespace ERP_API.Models
{
    public partial class ThirdCategory
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public int? TypeId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
