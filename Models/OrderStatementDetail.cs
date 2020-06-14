namespace ERP_API.Models
{
    public partial class OrderStatementDetail
    {
        public int Id { get; set; }
        public int OrderStatementId { get; set; }
        public int OrderId { get; set; }
    }
}
