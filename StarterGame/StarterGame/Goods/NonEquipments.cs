using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Goods
{
    enum ItemType { KEYITEM, CONSUMABLE}
    class NonEquipments : Items
    {
        // overriding the accessor in super class
        public override String ItemName { get { return itemName; } set { itemName = value; } }
        public override float Volumn { get { return volumn; } set { volumn = value; } }
        public override float Weight { get { return weight; } set { weight = value; } }
        public override int Count { get { return count; } set { count = value; } }
        public override float Worth { get { return worth; } set { worth = value; } }

        // accessor for item recovery and type
        private int healthRecovery;
        public int HealthRecovery { get { return healthRecovery; } set { healthRecovery = value; } }
        private int manaRecovery;
        public int ManaRecovery { get { return manaRecovery; } set { manaRecovery = value; } }
        private int techRecovery;
        public int TechRecovery { get { return techRecovery; } set { techRecovery = value; } }
        //private ItemType type;
        public ItemType Type { get { return type; } set { type = value; } }

        public NonEquipments(String ItemName, float Volumn, float Weight, int Count, float Worth, int HealthRecovery, int ManaRecovery, int TechRecovery, ItemType Type)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            this.HealthRecovery = HealthRecovery;
            this.ManaRecovery = ManaRecovery;
            this.TechRecovery = TechRecovery;
            this.Type = Type;
        }
    }
}
