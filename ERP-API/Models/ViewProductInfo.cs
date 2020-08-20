namespace ERP_API.Models
{
    public partial class ViewProductInfo
    {
        public bool IsChecked { get; set; }
        public string Params { get; set; }
        public string SourceUrl { get; set; }
        public int BranchId { get; set; }
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public int PhotoNum { get; set; }
        public int DetailPhotoNum { get; set; }
        public int DonvvSku { get; set; }
        public int? DataSource { get; set; }
    }
}
