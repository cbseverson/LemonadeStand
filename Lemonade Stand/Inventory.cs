using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        public List<Lemon>lemon;
        public List<Sugar>sugar;
        public List<Ice>ice;
        public List<Cup>cup;
        public Inventory()
        {
            lemon = new List<Lemon>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            cup = new List<Cup>();
        }
        public void remainingInventory()
        {
            UserInterface.userRemainingInventory(lemon.Count, sugar.Count, ice.Count, cup.Count);
        }
    }
}
