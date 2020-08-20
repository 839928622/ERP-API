using System;

namespace ERP_API.Models
{
    public partial class SysBranchPay
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int PaymentId { get; set; }
        public string Title { get; set; }
        public string AppId { get; set; }
        public string PartnerId { get; set; }
        public string Secret { get; set; }
        public string AppSecret { get; set; }
        public string PublicKey { get; set; }
        public string SslcertPath { get; set; }
        public int? Sort { get; set; }
        public DateTime? AddTime { get; set; }
        public string CertFileUrl { get; set; }
        public string BizType { get; set; }
    }
}
