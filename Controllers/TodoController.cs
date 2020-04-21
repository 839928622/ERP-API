using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ERP_API.Models.ToDo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;


namespace ERP_API.Controllers
{
    [ApiController]
    [Authorize]
    public class TodoController :ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        private readonly List<ToDo> _toDo;

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

            if (!_memoryCache.TryGetValue("toDoList",out List<ToDo> toDoList))
            {
                var options = new MemoryCacheEntryOptions();
                options.SetAbsoluteExpiration(TimeSpan.FromDays(1));//设置过期时间 1天
                _memoryCache.Set("toDoList", toDoList,options);//如果缓存里没有的话，就将数据放入缓存
            }
        }

        [HttpGet]
        public IActionResult GetToDoList()
        {
           var toDoList = _memoryCache.Get<List<ToDo>>("ToDoList");
           return Ok(toDoList);
        }
    }
}
