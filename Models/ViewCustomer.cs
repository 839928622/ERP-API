using System;

namespace ERP_API.Models
{
    public partial class ViewCustomer
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string EmployeesNum { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Telphone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string RegisterMethod { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Level { get; set; }
        public int SalesId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int StatementManId { get; set; }
        public int OrderDiscount { get; set; }
        public string OrderMemo { get; set; }
        public int OrderPrintNum { get; set; }
        public string StoreMemo { get; set; }
        public string StatementMemo { get; set; }
        public string PayType { get; set; }
        public string PayMethod { get; set; }
        public int Credit { get; set; }
        public int CreditDays { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceTaxNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public string InvoiceBank { get; set; }
        public string InvoiceBankAccount { get; set; }
        public string InvoiceContent { get; set; }
        public string InvoiceMemo { get; set; }
        public bool IsOrdering { get; set; }
        public bool IsMultiAccount { get; set; }
        public bool IsComfirmOrder { get; set; }
        public int ConfirmLevel { get; set; }
        public bool IsCounter { get; set; }
        public bool IsBuyOutCounter { get; set; }
        public bool IsBudget { get; set; }
        public bool IsStoreManager { get; set; }
        public string Py { get; set; }
        public string SalesName { get; set; }
        public bool IsPublic { get; set; }
        public bool? IsDisable { get; set; }
    }
}
