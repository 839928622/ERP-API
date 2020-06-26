using System.Threading.Tasks;
using ERP_API.Models;

namespace ERP_API.Service.Orders
{
    interface IOrderService
    {
        public  Task<SysBranchSetting> GetBranchSetting(int branchId);

    }
}
