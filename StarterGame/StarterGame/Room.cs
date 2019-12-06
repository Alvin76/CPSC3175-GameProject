using System.Collections;
using System.Collections.Generic;
using System;
using StarterGame.Goods;
using StarterGame.IGoods;

namespace StarterGame
{
    public class Room
    {
        private Dictionary<string, Room> exits;
        private List<IGoods.IGoods> itemInRoom;
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
        /*
         * This is broken all items are not working
         */
        /*
        public string getItems()
        {
            string itemsNames = "Item: ";
            Dictionary<string, Items>.KeyCollection keys = Items.Keys;
            foreach(object items in keys)
            {
                itemsNames += ", " + itemsNames;
            }

            return itemsNames;
        }
        */
        public string description()
        {
            return "You are " + this.tag + ".\n *** " + this.getExits();
        }
        //This for tradeing items 
        /*
        public string TradeRoom()
        {
            string itemsNames = "Item: ";
            Dictionary<string, Items>.KeyCollection keys = items.Keys;
            foreach (object items in keys)
            {
                itemsNames += ", " + itemsNames;
            }

            return itemsNames;
        }*/

        public String searchRoom()
        {
            String search = "";
            if(itemInRoom.Count == 0)
            {
                search = "There is nothing in the room!";
            }
            else
            {
                for (int index = 0; index < itemInRoom.Count; index++)
                {
                    search += "There is " + itemInRoom[index].ItemName + " in the room!\n";
                }
            }
            return search;
        }
    }
    
}
