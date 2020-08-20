using System;

namespace ERP_API.Models
{
    public partial class TransferPickingLog
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int TransferDetailId { get; set; }
        public int GoodsId { get; set; }
        public int StoreId { get; set; }
        public string StoreZone { get; set; }
        public int PickingUserId { get; set; }
        public int Num { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
