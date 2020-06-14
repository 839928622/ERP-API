namespace ERP_API.Models
{
    public partial class OrderInvoiceInfo
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string TaxNo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public string Memo { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
