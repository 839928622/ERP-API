using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_API.HubDataSimulator
{
    public static class DataManager
    {
        public static List<int> GetListInt()
        {
            var random = new Random();
            return new List<int>()
            {
                random.Next(1,10),
                random.Next(1,12),
                random.Next(1,12),
                random.Next(1,136)
            };
        }
    }
}
