using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Goods
{
    enum EquipType{ HEAD, BODY, LEG, SHOES, ARM}
    class Equipments : Items
    {
        // overriding the accessor in super class
        public override String ItemName { get { return itemName; } set { itemName = value; } } 
        public override float Volumn { get { return volumn; } set { volumn = value; } }
        public override float Weight { get { return weight; } set { weight = value; } }
        public override int Count { get { return count; } set { count = value; } }
        public override float Worth { get { return worth; } set { worth = value; } }

        // accessor for equipment stat value and type
        private int attackValue;
        public int AttackValue { get { return attackValue; } set { attackValue = value; } }
        private int defenseValue;
        public int DefenseValue { get { return defenseValue; } set { defenseValue = value; } }
        private EquipType type;
        public EquipType Type { get { return type; } set { type = value; } }

        // designated constructor
        public Equipments(String ItemName, float Volumn, float Weight, int Count, float Worth, int AttackValue, int DefenseValue, EquipType Type)
        {
            this.ItemName = ItemName;
            this.Volumn = Volumn;
            this.Weight = Weight;
            this.Count = Count;
            this.Worth = Worth;
            this.AttackValue = AttackValue;
            this.DefenseValue = DefenseValue;
            this.Type = Type;
        }

    }
}
