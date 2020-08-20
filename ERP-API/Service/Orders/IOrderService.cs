﻿using System.Threading.Tasks;
using ERP_API.Dtos.Orders;
using ERP_API.Models;

namespace ERP_API.Service.Orders
{
   public interface IOrderService
    {
        public  Task<SysBranchSetting> GetBranchSetting(int branchId);
        public NewOrderBranchList[] GetBranchLists(int branchId);
        public SalespersonList[] ReadSalespersonList(int branchId);
        public Company[] ReadCompanyAndGroup(int branchId);
    }
}
