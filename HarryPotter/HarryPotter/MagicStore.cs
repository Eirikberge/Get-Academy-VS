using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class MagicStore
    {
        public List<Item> petsList;
        public List<Item> wands;
        public List<Item> magicSpells;

        public MagicStore()
        {
            petsList = new List<Item>(){new Item("Rotte"), new Item("Ugle"), new Item("Katt")};
            wands = new List<Item>(){new Item("Føniksstav"), new Item("Unikornstav") , new Item("Trollstav") };
            magicSpells = new List<Item>();
        }




    }

    
}
