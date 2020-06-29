using System;

namespace ERP_API.Models
{
    public partial class FinanceSubject : BaseEntity
    {
       
        public string Code { get; set; }
        public string Pcode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? AddAt { get; set; }
        public DateTime? UpdatetAt { get; set; }
    }
}
