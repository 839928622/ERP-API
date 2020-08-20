using System;

namespace ERP_API.Models
{
    public partial class IErrLog
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string JsonStr { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
