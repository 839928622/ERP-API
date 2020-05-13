using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysCarUser
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
