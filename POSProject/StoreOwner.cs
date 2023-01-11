using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSProject
{
    public class StoreOwner : IDealConfiguration
    {
        private Dictionary<int, char> dealsfortheday = new Dictionary<int, char>();


        Dictionary<int, char> IDealConfiguration.DealConfiguration(int sku, char deal)
        {
            dealsfortheday.Add(sku, deal);
            return dealsfortheday;
        }
    }
}
