using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ERP_API.HubConfiguration;
using ERP_API.HubDataSimulator;
using ERP_API.Models;
using ERP_API.Service.BrandSettings;
using ERP_API.TimerFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ERP_API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AdvancedSettingController : ControllerBase
    {
        private readonly IHubContext<AdvancedSettingHub> _advancedHub;
        private readonly IBranchSettingService _branchSettingService;

        public AdvancedSettingController(IHubContext<AdvancedSettingHub> advancedContext,
                                         IBranchSettingService branchSettingService)
        {
            _advancedHub = advancedContext;
            this._branchSettingService = branchSettingService;
        }
        [HttpGet]
        public   IActionResult Get(int branchId)
        {
            var ss = _branchSettingService.GetBranchSetting(branchId).Result;
            // _branchSettingService.GetBranchSetting(branchId)

            var timerManager = new TimerManager(() =>  _advancedHub.Clients.All.SendAsync("branchSettings", _branchSettingService.GetBranchSetting(branchId)));    
             
            
            
            return Ok(new { message = "消息已发出" });
        }

        [HttpPost]
       // [Authorize(Roles = "BranchOwner")] could add some Authorize policy later
        public IActionResult UpdateBranchSetting(SysBranchSetting model)
        {
            _advancedHub.Clients.All.SendAsync("branchSettings", model);
            return Ok();
        }
    }
}