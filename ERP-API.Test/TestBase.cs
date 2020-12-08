using ERP_API.Infrastructure;
using ERP_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Security.Claims;
using Xunit;

namespace ERP_API.Test
{
    public class TestBase
    {
        public bool UserSqlite { get; set; }

      

        public ApplicationDbContext GetDbContext()
        {
            Mock<IHttpContextAccessor> httpContextAccessor = new Mock<IHttpContextAccessor>();
            var httpContext = new Mock<HttpContext>();
            httpContext.Setup(x => x.User.FindFirst(CustomizedClaims.BranchId)).Returns(new Claim(CustomizedClaims.BranchId, "1"));
            //_accessor = new Mock<IHttpContextAccessor>();
            //_accessor.Setup(x => x.HttpContext).Returns(httpContext);
            httpContextAccessor.Setup(x => x.HttpContext).Returns(httpContext.Object);

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            if(UserSqlite)
            {
                builder.UseSqlite("DataSource=:memory:", x => { });
            }
            else
            {
                builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            }
            var dbContext = new ApplicationDbContext(builder.Options, httpContextAccessor.Object);
            if(UserSqlite)
            {
                dbContext.Database.EnsureCreated();
            }
            dbContext.Database.EnsureCreated();

            return dbContext;
        }

        public void UseSqlite()
        {
            UserSqlite = true;
        }
    }
}
