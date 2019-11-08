using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    class NPC : IStats
    {
        private String name;
        public String Name { get { return name; } set { name = value; } }
        private int level;
        public int Level { get { return level; } set { level = value; } }
        private int atk;
        public int ATK { get { return atk; } set { atk = value; } }
        private int def;
        public int DEF { get { return def; } set { def = value; } }
        private int hp;
        public int HP { get { return hp; } set { hp = value; } }
        private int mp;
        public int MP { get { return mp; } set { mp = value; } }
        private int tp;
        public int TP { get { return tp; } set { tp = value; } }

        //designated constructure
        public NPC(String Name, int Level, int ATK, int DEF, int HP, int MP, int TP)
        {
            this.Name = Name;
            this.Level = Level;
            this.ATK = ATK;
            this.DEF = DEF;
            this.HP = HP;
            this.MP = MP;
            this.TP = TP;
        }
    }
}
