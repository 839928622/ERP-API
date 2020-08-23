using ERP_API.Models;
using Xunit;

namespace ERP_API.Test.Service.BranchSettingService
{
  public  class BranchSettingServiceTest : IClassFixture<ApplicationDbContextClassFixture>
    {
        private readonly ApplicationDbContext dbContext;

        public BranchSettingServiceTest(ApplicationDbContextClassFixture dbContextClassFixture)
        {
            this.dbContext = dbContextClassFixture.GetDbContext();
        }


    }
}
