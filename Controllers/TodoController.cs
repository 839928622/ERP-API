using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ERP_API.Models;
using ERP_API.Models.ToDo;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;


namespace ERP_API.Controllers
{
   
    [Route("[controller]/[action]")]
  
    public class TodoController : BaseController
    {
        private readonly IMemoryCache _memoryCache;
        private readonly List<ToDo> _toDo;
        private readonly ApplicationDbContext _dBContext;
       
        public TodoController(IMemoryCache memoryCache)
        {
            


            _memoryCache = memoryCache;
            _toDo = new List<ToDo>()
            {
                new ToDo()
                {
                    Id = new Guid(),
                    Title = "吃饭",
                    Completed = false
                },
                new ToDo()
                {
                    Id = new Guid(),
                    Title = "学习",
                    Completed = true
                },
                new ToDo()
                {
                    Id = new Guid(),
                    Title = "睡觉",
                    Completed = false
                },
            };
           



            if (!_memoryCache.TryGetValue("toDoList", out List<ToDo> toDoList))
            {
                var options = new MemoryCacheEntryOptions();
                options.SetAbsoluteExpiration(TimeSpan.FromDays(1));//设置过期时间 1天
                _memoryCache.Set("toDoList", _toDo,options);//如果缓存里没有的话，就将数据放入缓存
            }
        }
        [HttpGet]
       
        
        public async Task<IActionResult> GetToDoList()
        {
            var accessToken = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
            var toDoList = _memoryCache.Get<List<ToDo>>("toDoList");
           var branchId=  User.FindFirst("branchId").Value;//这个就是用户的branchId
           var xx = UserBranchId;
           
           return Ok(toDoList);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult TestToDo()
        {
            return Ok("您成功访问了测试页面");
        }
    }
}
