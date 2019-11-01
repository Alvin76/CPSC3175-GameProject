using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.IGoods
{
    enum ifKey { KEY, CONSUMABLE}

    class NewNonEquipments : IGoods
    {
        // basic accessor fuctions
        public String ItemName { get; set; }
        public float Volumn { get; set; }
        public float Weight { get; set; }
        public int Count { get; set; }
        public float Worth { get; set; }
        public ifKey Key { get; set; }

        public int HPRecovery { get; set; }
        public int MPRecovery { get; set; }
        public int TPRecovery { get; set; }

        public NewNonEquipments(String ItemName, float Volumn, float Weight, int Count, float Worth, ifKey Key, int HPRecovery, int MPRecovery, int TPRecovery)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            this.Key = Key;
            this.HPRecovery = HPRecovery;
            this.MPRecovery = MPRecovery;
            this.TPRecovery = TPRecovery;
        }
    }
}
