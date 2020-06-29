using System;

namespace ERP_API.Models
{
    public partial class CustomerBalanceLog : BaseEntity
    {
       
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Direction { get; set; }
        public decimal Change { get; set; }
        public decimal Amount { get; set; }
        public int? DeptId { get; set; }
        public string DeptName { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? RelationId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreationId { get; set; }
        public string Remark { get; set; }
    }
}
