using ERP_API.Models;
using System.Threading.Tasks;

namespace ERP_API.Service.BrandSettings
{
    public interface IBranchSettingService
    {
        SysBranchSetting GetBranchSetting(int branchId);
    }
}
