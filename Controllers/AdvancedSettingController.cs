using ERP_API.HubConfiguration;
using ERP_API.Service.BrandSettings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ERP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AdvancedSettingController : ControllerBase
    {
        private readonly IHubContext<AdvancedSettingHub> _advancedHub;
        private readonly IBranchSettingService _branchSettingService;

        public AdvancedSettingController(IHubContext<AdvancedSettingHub> advancedContext, IBranchSettingService branchSettingService)
        {
            _advancedHub = advancedContext;
            this._branchSettingService = branchSettingService;
        }

        public IActionResult Get(int branchId)
        {
            _advancedHub.Clients.All.SendAsync("branchSettings", _branchSettingService.GetBranchSetting(branchId));
            return Ok(new { message = "消息已发出" });
        }
    }
}