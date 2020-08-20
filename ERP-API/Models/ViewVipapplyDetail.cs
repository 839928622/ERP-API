namespace ERP_API.Models
{
    public partial class ViewVipapplyDetail
    {
        public int ApplyId { get; set; }
        public int MemberId { get; set; }
        public string Status { get; set; }
        public decimal SumMoney { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public bool IsDelete { get; set; }
        public string HomeImage { get; set; }
        public int Id { get; set; }
        public string MemberName { get; set; }
        public int MemberDeptId { get; set; }
        public string MemberDeptName { get; set; }
        public string MemberDeptCode { get; set; }
        public string MemberDeptPcode { get; set; }
        public int ConfirmLevel { get; set; }
        public int MinimumQuantity { get; set; }
        public int DisplayNum { get; set; }
        public string DisplayUnit { get; set; }
        public decimal DisplayPrice { get; set; }
    }
}
