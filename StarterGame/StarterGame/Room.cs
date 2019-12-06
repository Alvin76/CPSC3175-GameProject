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

        
        private bool victoryCondition;
        public bool VictoryCondition { get { return victoryCondition; } set { victoryCondition = value; } }
        private bool encounter;
        public bool Encounter { get { return encounter; } set { encounter = value; } }
        private Characters.Player player;

        public Room() : this("No Tag")
        {

        }

        public Room(string tag)
        {
            exits = new Dictionary<string, Room>();
            this.tag = tag;
            itemInRoom = new List<IGoods.IGoods>();
            VictoryCondition = false;
            Encounter = false;
            player = Characters.Player.getInstance();
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

        // adding item to room
        public void addItem(IGoods.IGoods item)
        {
            itemInRoom.Add(item);
        }

        // helper method
        public IGoods.IGoods findItem(String targetItem)
        {
            IGoods.IGoods search = null;
            for (int index = 0; index < itemInRoom.Count; index++)
            {
                if (itemInRoom[index].ItemName == targetItem)
                {
                    search = itemInRoom[index];
                }
            }
            return search;
        }

        // destroying item
        public void destoryItem(String itemName)
        {
            IGoods.IGoods target = findItem(itemName);
            if (target == null)
            {
                //place holder for now
                Console.WriteLine("There is no such item in this room!");
            }
            else
            {
                if (target.Destroyable)
                {
                    if (target.Count > 1)
                    {
                        findItem(itemName).Count -= 1;
                        Console.WriteLine("One of the following item is destroyed!");
                    }
                    else
                    {
                        Console.WriteLine("One of the item is destoryed!");
                        itemInRoom.Remove(findItem(itemName));
                    }
                }
                else
                {
                    Console.WriteLine("You can't destroy this item!");
                }
            }
        }

        //picking up 
        public IGoods.IGoods getItem(String itemName)
        {
            IGoods.IGoods target = findItem(itemName);
            if (target == null)
            {
                Console.WriteLine("Item does not exist in this room!");
            }
            else
            {
                if (target.Count > 1)
                {
                    findItem(itemName).Count -= 1;
                    Console.WriteLine("One of the " + target.ItemName + " item is placed in inventory!");
                }
                else
                {
                    Console.WriteLine("You placed " + target.ItemName + " into your inventory!");
                    itemInRoom.Remove(findItem(itemName));
                }
            }
            return target;
        }

        // room search
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
                    if (itemInRoom[index].Count == 1)
                    {
                        search += "There is " + itemInRoom[index].ItemName + " in the room!";
                    }
                    else
                    {
                        search += "There are " + itemInRoom[index].Count + " " + itemInRoom[index].ItemName + " in this room!";
                    }
                }
            }
            return search;
        }
        /*
        public void monsterEncounter()
        {
            if(Encounter)
            {
                Random rand = new Random();
                int monsterIndex = rand.Next(8);
                Characters.Monster newMonster = new Characters.Monster(monsterIndex);
                bool battle = true;
                while(player.Level < newMonster.EncounterLevel)
                {
                    monsterIndex = rand.Next(8);
                    newMonster = new Characters.Monster(monsterIndex);
                }

            }
            else
            {
                Console.WriteLine("There is nothing here.");
            }
        }*/
    }
    
}
