using System.Threading.Tasks;
using ERP_API.Models;
using ERP_API.Service.BranchSettings;
using Microsoft.AspNetCore.SignalR;

namespace ERP_API.HubConfiguration
{
    public class AdvancedSettingHub : Hub
    {
        /// <summary>
        /// Broadcast AdvancedSetting to all clients that listening on broadcastAdvancedSetting event
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task BroadcastAdvancedSetting(SysBranchSetting model) =>
            await Clients.All.SendAsync("broadcastAdvancedSetting", model);

        public string GetConnectionId() => Context.ConnectionId;
    }
}
