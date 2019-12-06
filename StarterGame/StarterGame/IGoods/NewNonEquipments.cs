using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.IGoods
{
    enum IfKey { KEY, CONSUMABLE}

    class NewNonEquipments : IGoods
    {
        // basic accessor fuctions
        private String itemName;
        public String ItemName { get { return itemName; } set { itemName = value; } }
        private float volumn;
        public float Volumn { get { return volumn; } set { volumn = value; } }
        private float weight;
        public float Weight { get { return weight; } set { weight = value; } }
        private int count;
        public int Count { get { return count; } set { count = value; } }
        private float worth;
        public float Worth { get { return worth; } set { worth = value; } }
        private IfKey key;
        public IfKey Key { get { return key; } set { key = value; } }
        private int hpRecovery;
        public int HPRecovery { get { return hpRecovery; } set { hpRecovery = value; } }
        private int mpRecovery;
        public int MPRecovery { get { return mpRecovery; } set { mpRecovery = value; } }
        /*
        private int tpRecovery;
        public int TPRecovery { get { return tpRecovery; } set { tpRecovery = value; } }
        */
        public NewNonEquipments(String ItemName, float Volumn, float Weight, int Count, float Worth, IfKey Key, int HPRecovery, int MPRecovery)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            this.Key = Key;
            this.HPRecovery = HPRecovery;
            this.MPRecovery = MPRecovery;
            //this.TPRecovery = TPRecovery;
        }
    }
}
