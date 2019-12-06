using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.IGoods
{
    //enum EquipmentsType { WEAPON, HEAD, SHIRT, SHOES}

    class NewEquipments : IGoods
    {
        // public accessor
        public String ItemName { get; set; }
        public float Volumn { get; set; }
        public float Weight { get; set; }
        public int Count { get; set; }
        public float Worth { get; set; }
        //public EquipmentsType Type{ get; set; }
        public int AttackValue;
        //public int DefenseValue;
        public int Durability { get; set; }

        public NewEquipments(String ItemName, float Volumn, float Weight, int Count, float Worth, int AttackValue, int Durability)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            //this.Type = Type;
            this.AttackValue = AttackValue;
            //this.DefenseValue = DefenseValue;
            this.Durability = Durability;
        }
    }
}
