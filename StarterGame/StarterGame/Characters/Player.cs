using System.Collections;
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
        private int level;
        public int Level { get { return level; } set { level = value; } }
        private int atk;
        public int ATK { get { return atk; } set { atk = value; } }
        private int def;
        public int DEF { get { return DEF; } set { def = value; } }
        private int hp;
        public int HP { get { return hp; } set { hp = value; } }
        private int mp;
        public int MP { get { return mp; } set { mp = value; } }
        private int tp;
        public int TP { get { return tp; } set { tp = value; } }

        //default constructor
        private Player()
        {
            Name = "Placeholder";// we need to figure out of we going allow player to make their own name or not
            Level = 1;
            ATK = DEF = 5;// ATK = 5; DEF = 5;
            HP = 15;
            MP = TP = 10;// MP = 10; TP = 10;
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
