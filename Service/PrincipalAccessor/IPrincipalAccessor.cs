using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ERP_API.Service.PrincipalAccessor
{
  public  interface IPrincipalAccessor
    {
        ClaimsPrincipal Principal { get; }
    }
}
