using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ERP_API.HubConfiguration;
using ERP_API.HubDataSimulator;
using ERP_API.Models;
using ERP_API.Service.BranchSettings;
using ERP_API.TimerFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ERP_API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AdvancedSettingController : BaseController
    {
        private readonly IHubContext<AdvancedSettingHub> _advancedHub;
        private readonly IBranchSettingService _branchSettingService;

        public AdvancedSettingController(IHubContext<AdvancedSettingHub> advancedContext,
                                         IBranchSettingService branchSettingService)
        {
            _advancedHub = advancedContext;
            this._branchSettingService = branchSettingService;
        }
        [HttpPost("/{connectionId}")]
        public async Task<IActionResult> JoinGroup(string connectionId)
        {
            // consider branchId  a group name , so all branch member automate be in a group
            await _advancedHub.Groups.AddToGroupAsync(connectionId, UserBranchIdString);
            return Ok();
        }
        [HttpPost("/{connectionId}")]
        public async Task<IActionResult> LeaveGroup(string connectionId)
        {
            await _advancedHub.Groups.RemoveFromGroupAsync(connectionId,UserBranchIdString);
            return Ok();
        }

        [HttpPost]
        // [Authorize(Roles = "BranchOwner")] could add some Authorize policy later
        public IActionResult UpdateBranchSetting(SysBranchSetting model)
        {
            _advancedHub.Clients.Group(UserBranchIdString).SendAsync($"branchSettings-{UserBranchIdString}", model);
            return Ok();
        }
        [HttpGet]
        public   IActionResult Get() // client push a request to start a room/channel/connection
        {
            // synchronized function
            var setting = _branchSettingService.GetBranchSetting(UserBranchId);
            
             _advancedHub.Clients.Group(UserBranchIdString).SendAsync($"branchSettings-{UserBranchIdString}", setting);    

            return Ok(new { message = "message have been sent" });
        }

    }
}