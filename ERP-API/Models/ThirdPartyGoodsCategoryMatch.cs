namespace ERP_API.Models
{
    public partial class ThirdPartyGoodsCategoryMatch
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ThirdPartyGoodsCategoryId { get; set; }
        public string ThirdPartyGoodsCategoryName { get; set; }
        public int LocalGoodsCategoryId { get; set; }
        public string LocalGoodsCategoryName { get; set; }
    }
}
