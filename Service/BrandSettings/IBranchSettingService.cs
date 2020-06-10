using ERP_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_API.Service.BrandSettings
{
    public interface IBranchSettingService
    {
        Task<SysBranchSetting> GetBranchSetting(int branchId);
    }
}
