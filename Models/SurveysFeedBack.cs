using System;

namespace ERP_API.Models
{
    public partial class SurveysFeedBack
    {
        public int Id { get; set; }
        public string Opinion { get; set; }
        public string Satisfaction { get; set; }
        public int BranchId { get; set; }
        public DateTime AddTime { get; set; }
        public int UserId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
    }
}
