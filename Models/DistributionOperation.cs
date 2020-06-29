namespace ERP_API.Models
{
    public partial class DistributionOperation : BaseEntity
    {
      
        public int OrderId { get; set; }
        public bool IsPicked { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsArrived { get; set; }
        public bool IsDelete { get; set; }
    }
}
