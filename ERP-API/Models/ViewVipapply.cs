using System;

namespace ERP_API.Models
{
    public partial class ViewVipapply
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Status { get; set; }
        public decimal SumMoney { get; set; }
        public string Address { get; set; }
        public int ConfirmLevel { get; set; }
        public int OperatorId { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceContent { get; set; }
        public bool IsDelete { get; set; }
        public string InvoiceCategory { get; set; }
        public string EmailForInvoice { get; set; }
        public string InvoiceInfo { get; set; }
        public string PayType { get; set; }
        public int DeptId { get; set; }
        public string MemberName { get; set; }
        public string DeptName { get; set; }
    }
}
