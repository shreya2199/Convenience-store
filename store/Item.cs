using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    public class Item : IDealConfiguration
    {
        int sku;
        String name;
        float price;
        public string deal { get; set; }
        public Item(int sku, string name, float price, string deal="d:nodeal")
        {
            this.sku = sku;
            this.name = name;
            this.price = price;
            this.deal = deal;
        }
        public void DealConfiguration()
        {
            Console.WriteLine($"The {name} has a deal {deal}");
        }
    }
    
}
