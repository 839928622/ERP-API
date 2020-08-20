namespace ERP_API.Service.ClaimAccessor
{
    public interface IClaimsAccessor
    {
        public string UserId { get; }
        public int UserBranchId { get; }
        public string UserBranchIdString { get; }

    }
}
