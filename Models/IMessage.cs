using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IMessage
    {
        public int Id { get; set; }
        public int IprojectId { get; set; }
        public int BranchId { get; set; }
        public int? Type { get; set; }
        public string Result { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string Remark { get; set; }
    }
}
