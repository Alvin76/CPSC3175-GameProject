using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    class NPC : IStats
    {
        // accessor from IStats
        public String Name { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int CurrentHP { get; set; }
        public bool Alive { get; set; }
        /*
        private String name;
        private int atk;
        private int def;
        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }
        private int currentHP;
        private int maxMP;
        public int MaxMP { get { return maxMP; } set { maxMP = value; } }
        private int currentMP;
        public int CurrentMP { get { return currentMP; } set { currentMP = value; } }
        private int maxTP;
        public int MaxTP { get { return maxTP; } set { maxTP = value; } }
        private int currentTP;
        public int CurrentTP { get { return currentTP; } set { currentTP = value; } }
        */
        private bool helper;
        public bool Helper { get { return helper; } set { helper = value; } }
        private List<String> dialog; // main dialog
        private List<String> help; // serve as a guide for the player, will only give to the friend so is mainly untouched

        //designated constructure
        public NPC(String Name, int ATK, int DEF, int HP, bool Helper)
        {
            this.Name = Name;
            this.ATK = ATK;
            this.DEF = DEF;
            CurrentHP = HP;
            /*
            this.MaxMP = CurrentMP = MP;
            this.MaxTP = CurrentTP = TP;
            */
            dialog = new List<String>();
            this.Helper = Helper;
            if(Helper)
            {
                help = new List<String>();
            }
        }

        // adding in npc dialog
        public void addDialog(String newDialog)
        {
            dialog.Add(newDialog);
        }

        //getting a specific dialog
        public String text(int index)
        {
            return dialog[index];
        }

        //making the helper similar to dialog but its o
        public String hint(int index)
        {
            String tips;
            if(Helper)
            {
                tips = help[index];
            }
            else
            {
                tips = "Invalid";
            }
            return tips;
        }

        // attacking a unit
        public void attack(IStats unit)
        {
            Console.WriteLine(Name + " attacks!");
            unit.takeDamage(ATK);
        }

        // taking damage
        public void takeDamage(int damage)
        {
            int defense = DEF / 2;
            if (damage < defense)
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
                Console.WriteLine(Name + " was defeated!");
                Alive = false;
            }
        }
    }
}
