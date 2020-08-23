using ERP_API.Models;
using System.Threading.Tasks;

namespace ERP_API.Service.BranchSettings
{
    public interface IBranchSettingService
    {
        SysBranchSetting GetBranchSetting(int branchId);
    }
}
