using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    class NPC : IStats
    {
        // accessor from IStats
        private String name;
        public String Name { get { return name; } set { name = value; } }
        private int atk;
        public int ATK { get { return atk; } set { atk = value; } }
        private int def;
        public int DEF { get { return def; } set { def = value; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }
        private int currentHP;
        public int CurrentHP { get { return currentHP; } set { currentHP = value; } }
        private int maxMP;
        public int MaxMP { get { return maxMP; } set { maxMP = value; } }
        private int currentMP;
        public int CurrentMP { get { return currentMP; } set { currentMP = value; } }
        private int maxTP;
        public int MaxTP { get { return maxTP; } set { maxTP = value; } }
        private int currentTP;
        public int CurrentTP { get { return currentTP; } set { currentTP = value; } }

        private bool helper;
        public bool Helper { get { return helper; } set { helper = value; } }
        private List<String> dialog; // main dialog
        private List<String> help; // serve as a guide for the player, will only give to the friend so is mainly untouched

        //designated constructure
        public NPC(String Name, int ATK, int DEF, int HP, int MP, int TP, bool Helper)
        {
            this.Name = Name;
            this.ATK = ATK;
            this.DEF = DEF;
            this.MaxHP = CurrentHP = HP;
            this.MaxMP = CurrentMP = MP;
            this.MaxTP = CurrentTP = TP;
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

    }
}
