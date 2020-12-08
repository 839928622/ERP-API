using ERP_API.Models;
using Xunit;

namespace ERP_API.Test.Service.BranchSettingService
{
  public  class BranchSettingServiceTest : IClassFixture<TestBase>
    {
        private readonly ApplicationDbContext dbContext;

        public BranchSettingServiceTest(TestBase dbContextClassFixture)
        {
            this.dbContext = dbContextClassFixture.GetDbContext();
        }


    }
}
