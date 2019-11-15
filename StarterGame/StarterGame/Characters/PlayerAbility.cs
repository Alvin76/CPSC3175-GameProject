using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.Characters
{
    class PlayerAbility : IAbility
    {
        // interface accessors
        private String abilityName;
        public String AbilityName { get { return abilityName; } set { abilityName = value; } }
        private int mpCost;
        public int MPCost { get { return mpCost; } set { mpCost = value; } }
        private int tpCost;
        public int TPCost { get { return tpCost; } set { tpCost = value; } }
        private AbilityType type;
        public AbilityType Type { get { return type; } set { type = value; } }
        private int levelRequirement;
        public int LevelRequirement { get { return levelRequirement; } set { levelRequirement = value; } }

        // designated constructore
        public PlayerAbility(String AbilityName, int MPCost, int TPCost, AbilityType Type, int LevelRequirement)
        {
            this.AbilityName = AbilityName;
            this.MPCost = MPCost;
            this.TPCost = TPCost;
            this.Type = Type;
            this.LevelRequirement = LevelRequirement;
        }
    }
}
