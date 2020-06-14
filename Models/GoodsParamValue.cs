namespace ERP_API.Models
{
    public partial class GoodsParamValue
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int ParamId { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
    }
}
