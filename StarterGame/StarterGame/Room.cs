using System.Collections;
using System.Collections.Generic;
using System;

namespace StarterGame
{
    public class Room
    {
        private Dictionary<string, Room> exits;
        private string _tag;
        public string tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }

        public Room() : this("No Tag")
        {

        }

        public Room(string tag)
        {
            exits = new Dictionary<string, Room>();
            this.tag = tag;
        }

        public void setExit(string exitName, Room room)
        {
            exits[exitName] = room;
        }

        public Room getExit(string exitName)
        {
            Room room = null;
            exits.TryGetValue(exitName, out room);
            return room;
        }

        public string getExits()
        {
            string exitNames = "Exits: ";
            Dictionary<string, Room>.KeyCollection keys = exits.Keys;
            foreach (string exitName in keys)
            {
                exitNames += " " + exitName;
            }

            return exitNames;
        }
        //this is going to return items that are avaible in the room
        public string getItems()
        {
            string itemsNames = "Item: ";
            Dictionary<string, items>.KeyCollection keys = items.Keys;
            foreach(object items in keys)
            {
                itemsNames += " " + itemsNames;
            }

            return itemsNames;
        }

        public string description()
        {
            return "You are " + this.tag + ".\n *** " + this.getExits();
        }
    }
}
