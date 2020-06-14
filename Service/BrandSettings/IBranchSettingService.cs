using ERP_API.Models;
using System.Threading.Tasks;

namespace ERP_API.Service.BrandSettings
{
    public interface IBranchSettingService
    {
        Task<SysBranchSetting> GetBranchSetting(int branchId);
    }
}
