using System;

namespace ERP_API.Models
{
    public partial class SysBranchArea
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int? AreaIndex { get; set; }
        public int TypeId { get; set; }
        public string AreaName { get; set; }
        public string LeftLayout { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Href1 { get; set; }
        public string Href2 { get; set; }
        public string Href3 { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string Image6 { get; set; }
        public string Image7 { get; set; }
        public string Image8 { get; set; }
        public string Href4 { get; set; }
        public string Href5 { get; set; }
        public string Href6 { get; set; }
        public string Href7 { get; set; }
        public string Href8 { get; set; }
        public string BackGroundColor { get; set; }
    }
}
