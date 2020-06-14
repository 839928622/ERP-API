using System;

namespace ERP_API.Models
{
    public partial class IProductsMapForZgly
    {
        public int Id { get; set; }
        public string IproductSku { get; set; }
        public int? DonvvSku { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? BranchId { get; set; }
    }
}
