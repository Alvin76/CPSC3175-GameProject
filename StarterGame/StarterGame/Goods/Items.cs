using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Goods
{
   // enum ItemType { KEYITEM, WEAPON, HEAD, SHIRT, PANTS, SHOES, GLOVES, CONSUMABLE, OTHER}
   // This needs to be abstract or interface this will cause the items that will be objects to be tightly cupoled to this.
   // I like how this is going though.
   // going to split it into equipment and non-equipment
    abstract class Items
    {
        protected String itemName;
        public abstract String ItemName { get; set;} // itemName accessor
        protected float volumn;
        public abstract float Volumn { get; set;} // volumn accessor
        protected float weight;
        public abstract float Weight { get; set; } // weight acessor
        protected int count;
        public abstract int Count { get; set; } // count accessor
        protected float worth;
        public abstract float Worth { get; set; } // worth acessor
    }
}
