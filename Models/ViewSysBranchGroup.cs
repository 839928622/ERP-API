using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewSysBranchGroup
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Province { get; set; }
        public int ProvinceSort { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public int CitySort { get; set; }
        public string CityAlias { get; set; }
        public string Address { get; set; }
        public string Telphone { get; set; }
        public string LinkMan { get; set; }
        public int IsUseSiteGoods { get; set; }
        public string Introduction { get; set; }
        public DateTime AddTime { get; set; }
        public int IsEnable { get; set; }
        public int UserNum { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Domain { get; set; }
        public string Domain2 { get; set; }
        public string DonvvDomain { get; set; }
        public bool IsEasy { get; set; }
        public int? GroupId { get; set; }
        public string JoinType { get; set; }
        public bool? IsGroupAccount { get; set; }
        public string GroupName { get; set; }
        public int? LeaderBranchId { get; set; }
        public int? GroupUserNum { get; set; }
        public DateTime? GroupExpiredDate { get; set; }
        public string Memo { get; set; }
    }
}
