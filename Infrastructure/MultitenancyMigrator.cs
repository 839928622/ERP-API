using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ERP_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace ERP_API.Infrastructure
{
    public static class MultitenancyMigrator
    {
        public static void Migrate()
        {
            foreach (var databaseInfo in NeededToBeMigrateDatabaseList)
            {
                Mock<IHttpContextAccessor> httpContextAccessor = new Mock<IHttpContextAccessor>();
                var httpContext = new Mock<HttpContext>();
                httpContext.Setup(x => x.User.FindFirst(CustomizedClaims.BranchId)).Returns(new Claim(CustomizedClaims.BranchId, databaseInfo.BranchId));
                //_accessor = new Mock<IHttpContextAccessor>();
                //_accessor.Setup(x => x.HttpContext).Returns(httpContext);
                httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContext.Object);


                using var applicationDbContext = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>(), httpContextAccessor.Object);
                applicationDbContext.Database.Migrate();
            }
            
        }

        private static List<BranchDatabaseInfo> NeededToBeMigrateDatabaseList { get; set; }=new List<BranchDatabaseInfo>()
        {
            new BranchDatabaseInfo()
            {
                BranchName = "BBC",
                BranchId = "1"
            }
        };

        
    }

    public class BranchDatabaseInfo
    {
        public  string BranchName { get; set; }
        public  string BranchId { get; set; }
    }

    
}
