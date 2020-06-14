using System;

namespace ERP_API.Models
{
    public partial class Franchisee
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyProvince { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyArea { get; set; }
        public string CompanyAddress { get; set; }
        public string ContractWay { get; set; }
        public string LocationProvince { get; set; }
        public string LocationCity { get; set; }
        public string LocationArea { get; set; }
        public string LocationAddress { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int RoleId { get; set; }
        public string Mobile { get; set; }
    }
}
