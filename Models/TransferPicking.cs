using System;

namespace ERP_API.Models
{
    public partial class TransferPicking
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int PickingUserId { get; set; }
        public int DistributeUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
