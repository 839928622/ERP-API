namespace ERP_API.Models
{
    public partial class StrategyItem
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int Type { get; set; }
        public int Mode { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? Extend1 { get; set; }
        public decimal? Extend2 { get; set; }
        public string Extend3 { get; set; }
        public int Category { get; set; }
    }
}
