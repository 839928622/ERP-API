using System;

namespace ERP_API.Models
{
    public partial class ViewTransferDeliveryBox
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int BoxId { get; set; }
        public string TransferBoxStatus { get; set; }
        public int CarId { get; set; }
        public int CarUserId { get; set; }
        public int StockOutUserId { get; set; }
        public string TransferDeliveryStatus { get; set; }
        public DateTime UpdateTime { get; set; }
        public int TransferDeliveryId { get; set; }
        public int TransferBoxId { get; set; }
    }
}
