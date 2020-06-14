namespace ERP_API.Models
{
    public partial class NeedToPurchaseOrder
    {
        public int Id { get; set; }
        public int NeedToPurchaseId { get; set; }
        public int OrderId { get; set; }
    }
}
