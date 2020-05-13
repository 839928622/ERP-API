using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewIprojectPlat
    {
        public int Id { get; set; }
        public int IPlatId { get; set; }
        public int BranchId { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string AccessToken { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public string PlatName { get; set; }
        public int IProviderId { get; set; }
        public string PlatMemo { get; set; }
        public string ProviderName { get; set; }
        public string ProviderMemo { get; set; }
        public bool? IsPostData { get; set; }
        public string PrivateKey { get; set; }
        public string ClientId { get; set; }
    }
}
