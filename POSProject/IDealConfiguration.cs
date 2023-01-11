using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSProject
{
     interface IDealConfiguration
    {

        Dictionary<int, char> DealConfiguration(int sku, char deal);
    }
}
