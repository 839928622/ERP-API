using System;

namespace ERP_API.Models
{
    public partial class DistributionCustomerReceiveMoneyDetail
    {
        public int Id { get; set; }
        public int ReceiveMoneyId { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal ChargeOffAmount { get; set; }
        public DateTime UpdateTime { get; set; }
        public string GoodsName { get; set; }
        public string Unit { get; set; }
        public bool IsDelete { get; set; }
    }
}
