using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSProject

{
    public class Item 
    {
        int sku;
        String name;
        float price;
       
        public Item (int sku, string name, float price)
        {
            this.sku = sku;
            this.name = name;
            this.price = price;
           
        }
        
    }
    
}
