using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSProject
{
    public class Payment
    {
        private int VAT;
        private double amount = 0;
        private List<CartItem> shoppingcart = new List<CartItem>();
        private Dictionary<int, char> inventoryItems;

        public Payment(int vAT, List<CartItem> shoppingcart, Dictionary<int, char> inventoryItems)
        {
            VAT = vAT;
            this.shoppingcart = shoppingcart;
            this.inventoryItems = inventoryItems;

        }
        //logic
        public double BillCalculator()
        {
            foreach (var cartitem in shoppingcart)
            {

                var deal = inventoryItems[cartitem.sku];
                if (deal == 'a')
                {
                    amount += cartitem.quantity * (cartitem.price - 1);

                }
                else if (deal == 'b')
                {
                    amount += 0.9 * cartitem.quantity * cartitem.price;

                }
                else if (deal == 'c')
                {
                    if (cartitem.quantity < 2)
                        amount += cartitem.price * cartitem.quantity;
                    else
                    {
                        var chargeableQuantity = (cartitem.quantity - cartitem.quantity / 3);
                        amount += cartitem.price * chargeableQuantity;
                    }

                }
            }
            //checking final amount
            Console.WriteLine(amount + (VAT / 100 * amount));

            return (amount + (VAT / 100 * amount));
        }
    }
}
