using System;

namespace ERP_API.Models
{
    public partial class SysBranchFloor
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int FloorIndex { get; set; }
        public int TypeId { get; set; }
        public string FloorName { get; set; }
        public string LeftLayout { get; set; }
        public bool? AutoSub { get; set; }
        public string Image1 { get; set; }
        public string Href1 { get; set; }
        public string Image2 { get; set; }
        public string Href2 { get; set; }
        public string Image3 { get; set; }
        public string Href3 { get; set; }
        public DateTime UpdateTime { get; set; }
        public string BackGroundColor { get; set; }
        public bool IsDisplayCustomerTypeAndGoods { get; set; }
    }
}
