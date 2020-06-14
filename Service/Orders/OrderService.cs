using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace ERP_API.Service.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ApplicationDbContext _applicationDbContext;

        public OrderService(IMemoryCache memoryCache, ApplicationDbContext applicationDbContext)
        {
            this._memoryCache = memoryCache;
            this._applicationDbContext = applicationDbContext;
        }
        public async Task<SysBranchSetting> GetBranchSetting(int branchId)
        {
            var branchSetting = _memoryCache.Get<SysBranchSetting>(branchId);
            if (branchSetting != null)
            {
                return branchSetting;
            }
            return await _applicationDbContext.SysBranchSetting.FirstOrDefaultAsync(x => x.BranchId == branchId);

        }
    }
}
