namespace ERP_API.Models
{
    public partial class GoodsTypeParam : BaseEntity
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public bool HasOption { get; set; }
        public bool IsCondition { get; set; }
    }
}
