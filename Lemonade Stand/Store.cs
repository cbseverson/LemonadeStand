using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        Player player;
        string purchase;
        string purchaseAmount;

        public Store(Player player)
        {
            this.player = player;
        }
        public void Shop()
        {
            Console.WriteLine("What do you want to buy? Choose lemons, ice, sugar, or cups");
            purchase = Console.ReadLine().ToLower();
            string purchaseAmount;
            int amount;

            switch (purchase)
            { 
                case "lemon":
                    Console.WriteLine("How many lemons do you want to buy?");
                    purchaseAmount = Console.ReadLine();
                    amount = int.Parse(UserInterface.userPurchase(new Lemon()));
                    PurchaseItem(new Lemon(), amount);
                    break;
                case "ice":
                    Console.WriteLine("How much ice do you want to buy?");
                    purchaseAmount = Console.ReadLine();
                    amount = int.Parse(UserInterface.userPurchase(new Ice()));
                    PurchaseItem(new Lemon(), amount);
                    break;
                case "sugar":
                    Console.WriteLine("How much sugar do you want to buy?");
                    purchaseAmount = Console.ReadLine();
                    amount = int.Parse(UserInterface.userPurchase(new Sugar()));
                    PurchaseItem(new Lemon(), amount);
                    break;
                case "cup":
                    Console.WriteLine("How many do you want to buy?");
                    purchaseAmount = Console.ReadLine();
                    amount = int.Parse(UserInterface.userPurchase(new Cup()));
                    PurchaseItem(new Lemon(), amount);
                    break;

            }
        }
        public void PurchaseItem(Items item, int amount)
        {
            double value = amount * item.GetCost();
            if (player.wallet.GetBalance(value))
            {
                // still need to subtract from wallet 
                if(item.names == "lemon")
                {
                    for (int i = 0; i < amount; i++)
                    {
                        player.inventory.lemon.Add(new Lemon());
                    }
                }
                else if(item.names == "ice")
                {
                    for (int i = 0; i < amount; i++)
                    {
                        player.inventory.ice.Add(new Ice());
                    }
                }
                else if(item.names == "sugar")
                {
                    for (int i = 0; i < amount; i++)
                    {
                        player.inventory.sugar.Add(new Sugar());
                    }
                }
                else if(item.names == "cup")
                {
                    for (int i = 0; i < amount; i++)
                    {
                        player.inventory.sugar.Add(new Sugar());
                    }
                }
            }
        }

    }
}
