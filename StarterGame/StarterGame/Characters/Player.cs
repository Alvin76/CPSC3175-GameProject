using System.Collections;
using System.Collections.Generic;
using System;

// problem on line 112 can't figure out why its doing that its not doing that for NPC nor Monsters

namespace StarterGame.Characters
{
    public class Player : IStats
    {
        // singleton for player class
        private static Player player = null;

        // interface accessors
        private String name;
        public String Name { get { return name; } set { name = value; } }
        private int atk;
        public int ATK { get { return atk; } set { atk = value; } }
        private int def;
        public int DEF { get { return DEF; } set { def = value; } }
        private int currentHP;
        public int CurrentHP { get { return currentHP; } set { currentHP = value; } }
        private bool alive;
        public bool Alive { get { return alive; } set { alive = false; } }
        /*
        private int maxTP;
        public int MaxTP { get { return maxTP; } set { maxTP = value; } }
        private int currentTP;
        public int CurrentTP { get { return currentTP; } set { currentTP = value; } }
        */

        // player only 
        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }
        private int maxMP;
        public int MaxMP { get { return maxMP; } set { maxMP = value; } }
        private int currentMP;
        public int CurrentMP { get { return currentMP; } set { currentMP = value; } }
        private bool inCombat;
        public bool InCombat { get { return inCombat; } set { inCombat = value; } }
        private int level;
        public int Level { get { return level; } set { level = value; } }
        private int[] levelPoint = new int[19] { 2, 6, 12, 20, 30, 42, 56, 72, 90, 110, 132, 156, 182, 210, 240, 272, 306, 342, 380 };
        private int exp;
        public int EXP { get { return exp; } set { exp = value; } }
        private List<PlayerAbility> abilityList = null;
        private float weightLimit;
        public float WeightLimit { get { return weightLimit; } set { weightLimit = value; } }
        private Inventory playerInventory;
        private IGoods.NewEquipments weapon;
        
        //default constructor
        private Player()
        {
            Name = "Ash";
            Level = 1;
            EXP = 0;
            ATK = DEF = 5;// ATK = 5; DEF = 5;  
            MaxHP = 15;
            MaxMP = 10;// MP = 10; TP = 10;
            Alive = true;
            abilityList = new List<PlayerAbility>();
            InCombat = false;
            weapon = null;
            playerInventory = Inventory.haveOne();

        }

        // player singleton
        public static Player getInstance()
        {
            if(player == null)
            {
                player = new Player();
            }
            return player;
        }

        // gaining exp
        private void gainExp(int newExp)
        {
            EXP += newExp;
            int totalLevelUp = levelUp(EXP); // checking level upif there is any
            Console.Write(Name + " level up " + totalLevelUp + " times!");
        }

        // leveling up
        private int levelUp(int experience)
        {
            int totalLevelUp = 0;
            if (experience < levelPoint[level - 1])
            {
                totalLevelUp = 0;
            }
            else
            {
                Console.WriteLine(Name + " have level up!");
                level += 1;
                MaxHP = CurrentHP = MaxHP + 3;
                MaxMP = CurrentMP = MaxHP + 2;
                ATK += ATK + 2;
                DEF += DEF + 1;
                // not subtracting from current exp but going up by level then check each level up requirement
                totalLevelUp = levelUp(experience) + 1;
            }
            return totalLevelUp;
        }
        
        // incomplete LearnAbility method, need to check for level not manually learn ability, unless you want to gain ability point as well
        private void LearnAbility(PlayerAbility newAbility)
        {
            // was thinking about the player have a fixed list of abilities outside of the player class, then add in abilites one by one as the player level up once the level requirement is reached
            abilityList.Add(newAbility);
        }

        // attacking a unit
        // I think this is a command and doesn't belong here and that is one of it's issues 
        /*public void attack(IStats unit)
        {
            Console.WriteLine(Name + " attacks!");
            unit.takeDamage(ATK);
        }

        // taking damage*/
 

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

        //checking if character is in combat or not
        private bool checkCombat()
        {
            return InCombat;
        }

        //changing combat state
        private void changeCombatStatus(bool state)
        {
            InCombat = state;
        }

        //view skill list
        private String ability()
        {
            String list = "";
            if (abilityList.Count != 0)
            {
                for(int index = 0; index < abilityList.Count; index++)
                {
                    if (Level >= abilityList[index].LevelRequirement)
                    {
                        list += abilityList[index].AbilityName + "\n";
                    }
                }
            }
            else
            {
                list = "There is no known abilities";
            }
            return list;
        }

        //helper function
        private PlayerAbility findAbility(String target)
        {
            PlayerAbility find = null;
            for (int index = 0; index < abilityList.Count; index++)
            {
                if (abilityList[index].AbilityName == target)
                {
                    find = abilityList[index];
                }
            }
            return find;
        }

        //checking if ability is available
        private bool existingAbility(String abilityName)
        {
            bool checking = false;
            if(findAbility(abilityName) != null)
            {
                checking = true;
            }
            else
            {
                checking = false;
            }
            return checking;
        }

        // checking if ability is usable
        private int usableAbility(String abilityName)
        {
            int effect = 0;
            PlayerAbility targetAbility = findAbility(abilityName);
            if (targetAbility != null)
            {
                if (Level >= targetAbility.LevelRequirement)
                {
                    if(CurrentMP - targetAbility.MPCost >= 0)
                    {
                        if(targetAbility.Type == AbilityType.HEAL)
                        {
                            effect = targetAbility.AbilityMod;
                        }
                        else if(targetAbility.Type == AbilityType.DAMAGE)
                        {
                            if(InCombat)
                            {
                                effect = targetAbility.AbilityMod;
                            }
                            else
                            {
                                Console.WriteLine("You cant not use this ability at this time.");
                                effect = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have the mana to use this ability!");
                        effect = 0;
                    }
                }
                else
                {
                    effect = 0;
                    Console.WriteLine("You are not high enough level to use this ability");
                }
            }
            else
            {
                effect = 0;
                Console.WriteLine("The following abillity does not exist!");
            }
            return effect;
        }

        

        private Room _currentRoom = null;
        public Room currentRoom
        {
            get
            {
                return _currentRoom;
            }
            set
            {
                _currentRoom = value;
            }
        }

        public Player(Room room)//, GameOutput output)
        {
            _currentRoom = room;
        }

        //This is to move into each room or how the GoComand works
        public void waltTo(string direction)
        {
            Room nextRoom = this._currentRoom.getExit(direction);
            if (nextRoom != null)
            {
                this._currentRoom = nextRoom;
                this.outputMessage("\n" + this._currentRoom.description());
            }
            else
            {
                this.outputMessage("\nThere is no door on " + direction);
            }
        }
        //This is to find items in the room
        /*
        public void findMe(string fObject)
        {
            Room items = this._currentRoom.//add funtion in rooms
        }*/

        public void outputMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
