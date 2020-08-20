namespace ERP_API.Models
{
    public partial class GoodsExtensions
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string Remark { get; set; }
        public int? VirtualSales { get; set; }
    }
}
