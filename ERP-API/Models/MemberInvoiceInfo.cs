namespace ERP_API.Models
{
    public partial class MemberInvoiceInfo
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string InvoiceCategory { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceContent { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceTaxNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public string InvoiceBank { get; set; }
        public string InvoiceBankAccount { get; set; }
        public string InvoiceMemo { get; set; }
        public string EmailForInvoice { get; set; }
        public int? CustomerId { get; set; }
        public bool? IsDefault { get; set; }
        public string InvoiceReceivePhone { get; set; }
    }
}
