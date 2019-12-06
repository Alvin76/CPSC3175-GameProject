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
        private int attackValue;
        public int AttackValue { get { return attackValue; } set { attackValue = value; } }
        //public int DefenseValue;
        private int durability;
        public int Durability { get { return durability; } set{ durability = value; } }
        public bool Destroyable { get; set; }
        public bool Useable { get; set; }

        public NewEquipments(String ItemName, float Volumn, float Weight, int Count, float Worth, int AttackValue, int Durability, bool Destroyable, bool Useable)
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
            this.Destroyable = Destroyable;
            this.Useable = Useable;
        }
    }
}
