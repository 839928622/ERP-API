using System;

namespace ERP_API.Models
{
    public partial class CanvassAgreement : BaseEntity
    {
        public string AgreementContent { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
       
    }
}
