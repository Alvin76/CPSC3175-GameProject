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
        private int abilityMod;
        public int AbilityMod { get { return abilityMod; } set { abilityMod = value; } }
        private AbilityType type;
        public AbilityType Type { get { return type; } set { type = value; } }

        // other player only value
        private int levelRequirement;
        public int LevelRequirement { get { return levelRequirement; } set { levelRequirement = value; } }
        private bool universalAbility;
        public bool UniversalAbility { get { return universalAbility; } set { universalAbility = value; } }
        private bool combatAbility;
        public bool CombatAbility { get { return combatAbility; } set { combatAbility = value; } }

        // designated constructore
        public PlayerAbility(String AbilityName, int MPCost, int TPCost, int AbilityMod, AbilityType Type, int LevelRequirement, bool UniversalAbility, bool CombatAbility)
        {
            this.AbilityName = AbilityName;
            this.MPCost = MPCost;
            this.TPCost = TPCost;
            this.AbilityMod = AbilityMod;
            this.Type = Type;
            this.LevelRequirement = LevelRequirement;
            this.UniversalAbility = UniversalAbility;
            this.CombatAbility = CombatAbility;
        }

        // ability that can be used 
        public bool canBeUse(bool ifCombat)
        {
            bool canBeUsed = false;
            if(UniversalAbility)
            {
                canBeUsed = true;
            }
            else
            {
                if(ifCombat == CombatAbility)
                {
                    canBeUsed = true;
                }
                else
                {
                    canBeUsed = false;
                }
            }
            return canBeUsed;
        }

    }
}
