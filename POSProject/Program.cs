using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSProject
{
    public class Program
    {
        public const string apple = "Apples";
        public const string hairtie = "Haitie";
        public const string amul = "amulbutter";

        static void Main(string[] args)
        {
            // Filling Inventory
            Item Appleitem = new Item(453, apple, 75);
            Item hairtietem = new Item(799, hairtie, 15);
            Item AmulButteritem = new Item(799, amul, 15);


            //Store Owner setting the deals for the day
            IDealConfiguration Dealsconfigure = new StoreOwner();
            var dealsfortheday1 = Dealsconfigure.DealConfiguration(453, 'a');
            var dealsfortheday2 = Dealsconfigure.DealConfiguration(799, 'b');
            var dealsfortheday3 = Dealsconfigure.DealConfiguration(125, 'c');

            // customer shopping adding items to cart

            CartItem ItemType1 = new CartItem(453, 3, 75);
            CartItem ItemType2 = new CartItem(799, 3, 15);
            CartItem ItemType3 = new CartItem(125, 6, 20);

            List<CartItem> shoppingcart = new List<CartItem>();
            shoppingcart.Add(ItemType1);
            shoppingcart.Add(ItemType2);
            shoppingcart.Add(ItemType3);                 

            // Final BillPayment

            Payment Bill = new Payment(5, shoppingcart, dealsfortheday3);
            var TotalAmountTobePain = Bill.BillCalculator();





        }
    }
}
