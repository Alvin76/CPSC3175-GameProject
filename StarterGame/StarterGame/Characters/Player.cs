﻿using System.Collections;
using System.Collections.Generic;
using System;

namespace StarterGame.Characters
{
    public class Player : IStats
    {
        // singleton for player class
        private static Player player = null;
        // interface functions
        private String name;
        public String Name { get { return name; } set { name = value; } }
        private int atk;
        public int ATK { get { return atk; } set { atk = value; } }
        private int def;
        public int DEF { get { return DEF; } set { def = value; } }
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

        // player only 
        private int level;
        public int Level { get { return level; } set { level = value; } }
        private int[] levelPoint = new int[19] { 2, 6, 12, 20, 30, 42, 56, 72, 90, 110, 132, 156, 182, 210, 240, 272, 306, 342, 380 };
        private int exp;
        public int EXP { get { return exp; } set { exp = value; } }

        //default constructor
        private Player()
        {
            Name = "Placeholder";// we need to figure out of we going allow player to make their own name or not
            Level = 1;
            EXP = 0;
            ATK = DEF = 5;// ATK = 5; DEF = 5;
            MaxHP = 15;
            MaxMP = MaxTP = 10;// MP = 10; TP = 10;
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

        public void gainExp(int newExp)
        {
            EXP += newExp;
            int totalLevelUp = levelUp(EXP);


        }

        public int levelUp(int experience)
        {
            int totalLevelUp = 0;
            if (experience < levelPoint[level - 1])
            {
                totalLevelUp = 0;
            }
            else
            {
                level += 1;
                totalLevelUp = levelUp(experience) + 1;
            }
            return totalLevelUp;
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
