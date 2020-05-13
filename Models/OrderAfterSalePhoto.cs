using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class OrderAfterSalePhoto
    {
        public int Id { get; set; }
        public int AfterSaleId { get; set; }
        public int OrderId { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime AddTime { get; set; }
    }
}
