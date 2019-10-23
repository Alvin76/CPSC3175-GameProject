using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Inventory
    {
        private static Inventory onlyOne = null;
        public Dictionary<Int32, Items> inventory;
        private static float maxVolumn;
        private static float maxWeight;

        public Inventory()
        {
            inventory = new Dictionary<int, Items>();

        }

        public static Inventory haveOne()
        {
            if(onlyOne == null)
            {
                onlyOne = new Inventory();
            }

            return onlyOne;
        }
    }
}
