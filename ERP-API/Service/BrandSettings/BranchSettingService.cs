using System.Linq;
using ERP_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace ERP_API.Service.BrandSettings
{
    public class BranchSettingService : IBranchSettingService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ApplicationDbContext _applicationDbContext;

        public BranchSettingService(IMemoryCache memoryCache, ApplicationDbContext applicationDbContext)
        {
            this._memoryCache = memoryCache;
            this._applicationDbContext = applicationDbContext;
        }
        public  SysBranchSetting GetBranchSetting(int branchId)
        {
            var branchSetting = _memoryCache.Get<SysBranchSetting>(branchId);
            if (branchSetting != null)
            {
                return branchSetting;
            }
            var res =  _applicationDbContext.SysBranchSetting.FirstOrDefault();
            _memoryCache.Set(branchId, res);
            return res;
        }
    }
}
