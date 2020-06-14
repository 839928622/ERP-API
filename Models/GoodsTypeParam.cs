namespace ERP_API.Models
{
    public partial class GoodsTypeParam
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public bool HasOption { get; set; }
        public bool IsCondition { get; set; }
        public int BranchId { get; set; }
    }
}
