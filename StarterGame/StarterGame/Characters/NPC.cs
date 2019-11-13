using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    class NPC : IStats
    {
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

        private List<String> dialog = new List<String>();

        //designated constructure
        public NPC(String Name, int ATK, int DEF, int HP, int MP, int TP)
        {
            this.Name = Name;
            this.ATK = ATK;
            this.DEF = DEF;
            this.MaxHP = CurrentHP = HP;
            this.MaxMP = CurrentMP = MP;
            this.MaxTP = CurrentTP = TP;
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
    }
}
