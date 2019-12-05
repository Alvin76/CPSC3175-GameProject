﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    interface IStats
    {
        // basic accessor functions
        String Name { get; set; }
        int ATK { get; set; }
        int DEF { get; set; }
        int MaxHP { get; set; }
        int CurrentHP { get; set; }
        int MaxMP { get; set; }
        int CurrentMP { get; set; }
        int MaxTP { get; set; }
        int CurrentTP { get; set; }

    }
}
