using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.IGoods
{

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
        private int hpRecovery;
        public int HPRecovery { get { return hpRecovery; } set { hpRecovery = value; } }
        //private int mpRecovery;
        //public int MPRecovery { get { return mpRecovery; } set { mpRecovery = value; } }
        private bool destroyable;
        public bool Destroyable { get { return destroyable; } set {destroyable = value; } }
        private bool useable;
        public bool Useable { get { return useable; } set { useable = value; } }
        /*
        private int tpRecovery;
        public int TPRecovery { get { return tpRecovery; } set { tpRecovery = value; } }
        */
        public NewNonEquipments(String ItemName, float Volumn, float Weight, int Count, float Worth, int HPRecovery, bool Destroyable)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            this.HPRecovery = HPRecovery;
            //this.MPRecovery = MPRecovery;
            this.Destroyable = Destroyable;
            if(HPRecovery > 0)
            {
                Useable = true;
            }
            //this.TPRecovery = TPRecovery;
        }
    }
}
