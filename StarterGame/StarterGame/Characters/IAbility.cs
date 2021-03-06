﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    enum AbilityType { DAMAGE, HEAL}
    interface IAbility
    {
        String AbilityName { get; set; }
        int MPCost { get; set; }
        int TPCost { get; set; }
        int AbilityMod { get; set; }
        AbilityType Type { get; set; }
    }
}
