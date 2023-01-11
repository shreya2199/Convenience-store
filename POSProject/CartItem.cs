using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSProject
{
    public class CartItem
    {
       public int sku { get; set; }
       public int quantity { get; set; }
       public float price { get; set; }
        public CartItem(int sku, int quantity , float price)
        {
            this.sku = sku;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
