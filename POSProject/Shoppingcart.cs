using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSProject
{
    public class ShoppingCart
    {
       private  List<CartItem> CartItems;
        public ShoppingCart(List<CartItem> cartItems)
        {
            CartItems = cartItems;
        }
    }
}
