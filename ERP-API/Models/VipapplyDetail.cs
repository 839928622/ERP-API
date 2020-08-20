namespace ERP_API.Models
{
    public partial class VipapplyDetail
    {
        public int Id { get; set; }
        public int ApplyId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public int DisplayNum { get; set; }
        public string DisplayUnit { get; set; }
        public decimal DisplayPrice { get; set; }
    }
}
