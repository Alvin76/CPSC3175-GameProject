using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Goods
{
   // enum ItemType { KEYITEM, WEAPON, HEAD, SHIRT, PANTS, SHOES, GLOVES, CONSUMABLE, OTHER}
   // This needs to be abstract or interface this will cause the items that will be objects to be tightly cupoled to this.
   // I like how this is going though.
    class Items
    {
        private String itemName;
        public String ItemName { get { return itemName; } set { itemName = value; } } // itemName accessor
        private float volumn;
        public float Volumn { get { return volumn; } set { volumn = value; } } // volumn accessor
        private float weight;
        public float Weight { get { return weight; } set { weight = value; } } // weight acessor
        private int count;
        public int Count { get { return count; } set { count = value; } } // count accessor
        private float worth;
        public float Worth { get { return worth; } set { worth = value; } } // worth acessor
        private ItemType type;
        public ItemType Type { get { return type; } set { type = value; } } // type accessor

        // designated constructor
        public Items(String ItemName, float Volumn, float Weight, int Count, float Worth, ItemType Type)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            this.Type = Type;
        }
    }
}
