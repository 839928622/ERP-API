using System;

namespace ERP_API.Models
{
    public partial class IOrders
    {
        public int Id { get; set; }
        public int IProjectId { get; set; }
        public string IOrderId { get; set; }
        public string ICustomer { get; set; }
        public decimal SumMoney { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
