namespace ERP_API.Models
{
    public partial class IProjectExtention
    {
        public int Id { get; set; }
        public int IProjectId { get; set; }
        public string PropName { get; set; }
        public string PropValue { get; set; }
    }
}
