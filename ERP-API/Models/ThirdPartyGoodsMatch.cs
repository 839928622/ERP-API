namespace ERP_API.Models
{
    public partial class ThirdPartyGoodsMatch
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ThirdPartyGoodsId { get; set; }
        public string ThirdPartyGoodsName { get; set; }
        public int LocalGoodsId { get; set; }
        public string LocalGoodsName { get; set; }
    }
}
