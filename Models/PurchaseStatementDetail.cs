using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PurchaseStatementDetail
    {
        public int Id { get; set; }
        public int PurchaseStatementId { get; set; }
        public int PurchaseId { get; set; }
    }
}
