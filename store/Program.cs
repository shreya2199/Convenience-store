using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using store;

class Program
{
    static void Main(string[] args)
    {


        Console.Write("Enter deal for Apple: a.INR 1 off the normal price of an item. b.	10% off the normal price of an item. c.	Buy two items, get one item free.");
        var Appledeal = Convert.ToString(Console.Read);
        Item Appleitem = new Item(453, "Apples", 75, Appledeal);

        Console.Write("Enter deal for hairtie: a.INR 1 off the normal price of an item. b.10% off the normal price of an item. c.	Buy two items, get one item free.");
        var hairtiedeal = Convert.ToString(Console.Read);
        Item hairtitem = new Item(799, "Haitie", 15, hairtiedeal);

        Console.Write("Enter deal for Amul Butter : a.INR 1 off the normal price of an item.b.	10% off the normal price of an item. c.	Buy two items, get one item free.");
        var AmulButterdeal = Convert.ToString(Console.Read);
        Item AmulButteritem = new Item(799, "Haitie", 15, AmulButterdeal);

        // Customer Side 

      



    }
}



