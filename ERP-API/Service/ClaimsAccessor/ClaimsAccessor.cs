using ERP_API.Infrastructure;
using ERP_API.Service.ClaimAccessor;
using ERP_API.Service.PrincipalAccessor;
using IdentityModel;
using System;
using System.Linq;

namespace ERP_API.Service.ClaimsAccessor
{
    public class ClaimsAccessor : IClaimsAccessor
    {
        private IPrincipalAccessor PrincipalAccessor { get; }

        public ClaimsAccessor(IPrincipalAccessor principalAccessor)
        {
            PrincipalAccessor = principalAccessor;
        }
        public string UserId
        {

            get
            {
                var userId = PrincipalAccessor.Principal?.Claims.FirstOrDefault(c => c.Type == JwtClaimTypes.Subject)?.Value;
                return userId;
            }

        }

        public int UserBranchId
        {
            get
            {
                var userId = PrincipalAccessor.Principal?.Claims.FirstOrDefault(c => c.Type == CustomizedClaims.BranchId)?.Value;
                if (userId == null)
                {
                    throw new NullReferenceException("Cant not access UserBranchId by UserClaims");
                }
                return Convert.ToInt32(userId);
            }
        }

        public string UserBranchIdString
        {
            get
            {
                return PrincipalAccessor.Principal?.Claims.FirstOrDefault(c => c.Type == CustomizedClaims.BranchId)?.Value;
            }
        }
    }
}
