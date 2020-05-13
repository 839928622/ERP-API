using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GroupOrderStatementDetail
    {
        public int Id { get; set; }
        public int OrderStatementId { get; set; }
        public int OrderId { get; set; }
    }
}
