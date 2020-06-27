using System.Linq;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using ERP_API.Dtos.Orders;
using Mapster;

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

        public NewOrderBranchList[] GetBranchLists(int branchId)
        {
            var isLeadBranch = _applicationDbContext.ViewSysBranchGroup.Where(x => x.Id == branchId && x.JoinType == "总公司");
            if (isLeadBranch.Any())
            {
                return _applicationDbContext.ViewSysBranchGroup.Where(x => x.LeaderBranchId == branchId)
                    .ProjectToType<NewOrderBranchList>().ToArray();
            }

            return _applicationDbContext.ViewSysBranchGroup.Where(x => x.Id == branchId)
                .ProjectToType<NewOrderBranchList>().ToArray();
        }

        public SalespersonList[] ReadSalespersonList(int branchId)
        {
            return _applicationDbContext.SysUsers.Where(x => x.BranchId == branchId).ProjectToType<SalespersonList>()
                .ToArray();
        }
    }
}
