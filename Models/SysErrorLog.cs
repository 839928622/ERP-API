using System;

namespace ERP_API.Models
{
    public partial class SysErrorLog
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string RelationId { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
