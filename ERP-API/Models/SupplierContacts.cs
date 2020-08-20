namespace ERP_API.Models
{
    public partial class SupplierContacts
    {
        public int Id { get; set; }
        public int DepId { get; set; }
        public int SuppplierId { get; set; }
        public string Name { get; set; }
        public string Moblie { get; set; }
        public string Telphone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsDefault { get; set; }
    }
}
