using ERP_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace ERP_API.Test
{
    public class TestBase
    {
        public bool userSqlite { get; set; }
        public ApplicationDbContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            if(userSqlite)
            {
                builder.UseSqlite("DataSource=:memory:", x => { });
            }
            else
            {
                builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            }
            HttpContextAccessor Accessor = new HttpContextAccessor();
            var dbContext = new ApplicationDbContext(builder.Options, Accessor);
            if(userSqlite)
            {
                dbContext.Database.EnsureCreated();
            }
            dbContext.Database.EnsureCreated();

            return dbContext;
        }

        public void UseSqlite()
        {
            userSqlite = true;
        }
    }
}
