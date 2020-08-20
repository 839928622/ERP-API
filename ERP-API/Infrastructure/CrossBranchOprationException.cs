using System;

namespace ERP_API.Infrastructure
{
    public class CrossBranchOperationException : Exception
    {
        public CrossBranchOperationException(string message) : base(message)
        {

        }
    }
}
