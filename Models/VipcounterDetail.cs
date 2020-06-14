using System;

namespace ERP_API.Models
{
    public partial class VipcounterDetail
    {
        public int Id { get; set; }
        public int CounterId { get; set; }
        public int GoodsId { get; set; }
        public decimal Vipprice { get; set; }
        public int Level { get; set; }
        public bool? IsSales { get; set; }
        public DateTime AddTime { get; set; }
    }
}
