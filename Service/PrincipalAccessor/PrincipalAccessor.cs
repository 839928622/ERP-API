using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ERP_API.Service.PrincipalAccessor
{
    public class PrincipalAccessor : IPrincipalAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PrincipalAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
       
        public ClaimsPrincipal Principal  => _httpContextAccessor.HttpContext?.User;
    }
}
