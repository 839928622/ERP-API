using System;
using IdentityModel;
using Microsoft.AspNetCore.Mvc;

namespace ERP_API.Controllers
{
    
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
            this.UserBranchId = Convert.ToInt32(User.FindFirst("branchId").Value);
            this.UserId = User.FindFirst(JwtClaimTypes.Id).Value;

        }

        protected int UserBranchId { get; }
        protected string UserId { get; }
    }
}
