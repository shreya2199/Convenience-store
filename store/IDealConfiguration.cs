using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    internal interface IDealConfiguration
    {
        public string deal { get; set; }
        public void DealConfiguration();
    }
}
