using System;

namespace ERP_API.Models
{
    public partial class SysCarLog
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public decimal Kil { get; set; }
        public decimal Oil { get; set; }
        public decimal OilMoney { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
