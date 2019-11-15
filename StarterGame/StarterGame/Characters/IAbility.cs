using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    enum AbilityType { DAMAGE, HEAL, OTHER}
    interface IAbility
    {
        String AbilityName { get; set; }
        int MPCost { get; set; }
        int TPCost { get; set; }
        AbilityType Type { get; set; }
    }
}
