using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_API.Infrastructure
{
    public class CrossBranchOperationException : Exception
    {
        public CrossBranchOperationException(string message) : base(message)
        {
            
        }
    }
}
