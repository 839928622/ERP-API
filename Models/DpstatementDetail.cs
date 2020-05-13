using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class DpstatementDetail
    {
        public int Id { get; set; }
        public int DpstatementId { get; set; }
        public int OrderId { get; set; }
    }
}
