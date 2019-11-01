using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.IGoods
{
    enum EquipmentsType { WEAPON, HEAD, SHIRT, SHOES}

    class NewEquipments : IGoods
    {
        // public accessor
        public String ItemName { get; set; }
        public float Volumn { get; set; }
        public float Weight { get; set; }
        public int Count { get; set; }
        public float Worth { get; set; }
        public EquipmentsType Type{ get; set; }
        public int AttackValue;
        public int DefenseValue;

        public NewEquipments(String ItemName, float Volumn, float Weight, int Count, float Worth, EquipmentsType Type, int AttackValue, int DefenseValue)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            this.Type = Type;
            this.AttackValue = AttackValue;
            this.DefenseValue = DefenseValue;
        }
    }
}
