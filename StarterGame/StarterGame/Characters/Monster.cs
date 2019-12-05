using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    class Monster : IStats
    {
        public String Name { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        /*
        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }
        */
        public int CurrentHP { get; set; }
        public bool Alive { get; set; }
        /*
        private int maxMP;
        public int MaxMP { get { return maxMP; } set { maxMP = value; } }
        private int currentMP;
        public int CurrentMP { get { return currentMP; } set { currentMP = value; } }
        private int maxTP;
        public int MaxTP { get { return maxTP; } set { maxTP = value; } }
        private int currentTP;
        public int CurrentTP { get { return currentTP; } set { currentTP = value; } }
        */
        public int MonsterEXP { get; set; }
        public int GoldDrop { get; set; }
        public int EncounterLevel { get; set; }

        String[] MonsterName = { "Slime", "Gnome", "Goblin", "Pixie", "Imp", "Vampire Bat", "Werewolf" };
        int[] HPVals = { 10, 13, 16, 21, 25, 27, 40 };
        int[] ATKVals = { 3, 5, 7, 11, 15, 19, 35 };
        int[] DEFVals = { 1, 2, 4, 6, 9, 11, 20 };
        int[] EXPVals = { 2, 3, 4, 6, 9, 12, 50 };
        int[] GoldVals = { 1, 3, 5, 7, 9, 11, 30 };
        int[] LevelVals = { 1, 2, 3, 5, 6, 7, 10};
        
        public Monster(int result)
        {
            Name = MonsterName[result];
            CurrentHP = HPVals[result];
            ATK = ATKVals[result];
            DEF = DEFVals[result];
            Alive = true;
            MonsterEXP = EXPVals[result];
            GoldDrop = GoldVals[result];
            EncounterLevel = LevelVals[result];
            //this.MaxMP = CurrentMP = MP;
            //this.MaxTP = CurrentTP = TP;
        }

        // attacking a target
        public void attack(IStats unit)
        {
            Console.WriteLine(Name + " attacks!");
            unit.takeDamage(ATK);
        }

        // taking damage
        public void takeDamage(int damage)
        {
            int defense = DEF / 2;
            if(damage < defense)
            {
                CurrentHP -= 1;
                Console.WriteLine(Name + " took 1 damage!");
            }
            else
            {
                CurrentHP -= damage - defense;
                Console.WriteLine(Name + " took " + (damage - defense) + " damage!");
            }

            Console.WriteLine("\t HP: " + CurrentHP);

            if (CurrentHP <= 0)
            {
                Console.WriteLine(Name + " was defeated!\n You gain " + MonsterEXP + " EXP and " + GoldDrop + " gold coins");
                Alive = false;
            }
        }
    }
}
