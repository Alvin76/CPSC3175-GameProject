using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    interface IStats
    {
        // basic accessor functions
        String Name { get; set; }
        int Level { get; set; }
        int ATK { get; set; }
        int DEF { get; set; }
        int HP { get; set; }
        int MP { get; set; }
        int TP { get; set; }
    }
}
