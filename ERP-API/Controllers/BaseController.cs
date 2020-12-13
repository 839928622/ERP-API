using ERP_API.Infrastructure;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;


namespace ERP_API.Controllers
{

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {

        protected string UserId => User.FindFirst(JwtClaimTypes.Subject).Value;
        protected int UserBranchId => Convert.ToInt32(User.FindFirst(CustomizedClaims.BranchId).Value);
        protected string UserBranchIdString => User.FindFirst(CustomizedClaims.BranchId).Value;
    }
}
