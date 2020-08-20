using System;

namespace ERP_API.Models
{
    public partial class DeptTemp
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public int Level { get; set; }
        public bool IsSepareSettle { get; set; }
        public bool IsSepareOrder { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal Balance { get; set; }
        public bool IsBalance { get; set; }
    }
}
