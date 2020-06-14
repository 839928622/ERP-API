using System.Security.Claims;

namespace ERP_API.Service.PrincipalAccessor
{
    public interface IPrincipalAccessor
    {
        ClaimsPrincipal Principal { get; }
    }
}
