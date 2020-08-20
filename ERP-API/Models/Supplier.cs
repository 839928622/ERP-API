using System;

namespace ERP_API.Models
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool? IsEnable { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Type { get; set; }
        public string Attitude { get; set; }
        public string InvoiceType { get; set; }
        public string PayType { get; set; }
        public string LinkMan { get; set; }
        public string TelPhone { get; set; }
        public string Mobile { get; set; }
        public string Qq { get; set; }
        public string Address { get; set; }
        public string MainBrand { get; set; }
        public string Major { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string PassWord { get; set; }
        public string Py { get; set; }
        public bool? IsPublic { get; set; }
        public int AddUserId { get; set; }
        public string SupplierTaxNo { get; set; }
        public string OpeningBank { get; set; }
        public string BankAccount { get; set; }
        public int ExpiredPayment { get; set; }
        public string AddUserName { get; set; }
        public string DonvvSupplierId { get; set; }
    }
}
