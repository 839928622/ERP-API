using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class TransferDetail
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public int PickNum { get; set; }
        public int ReceivedNum { get; set; }
        public string ReceivedStatus { get; set; }
        public string SingleRemark { get; set; }
    }
}
