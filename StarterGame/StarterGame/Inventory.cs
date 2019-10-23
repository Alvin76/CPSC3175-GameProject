using System;
using System.Collections.Generic;
using System.Text;
using StarterGame.Goods;

namespace StarterGame
{
    class Inventory
    {
        private static Inventory playerInventory = null;
        public Dictionary<String, Items> inventory;
        private static float maxVolumn; // m^3
        private static float maxWeight; // kg
        private float currentVolumn;
        private float currentWeight;

        private Inventory()
        {
            inventory = new Dictionary<string, Items>();
            maxVolumn = 250f;
            maxWeight = 15f;
            currentVolumn = 0f;
            currentWeight = 0f;
        }

        public static Inventory haveOne()
        {
            if(playerInventory == null)
            {
                playerInventory = new Inventory();
            }

            return playerInventory;
        }

        // adding item
        public void addItem(Items newItem)
        {
            if(currentWeight + newItem.Weight <= maxWeight && currentVolumn + newItem.Volumn <= maxVolumn)
            {
                inventory.Add(newItem.ItemName, newItem);
                currentWeight += newItem.Weight;
                currentVolumn += newItem.Volumn;
            }
            else if(currentWeight + newItem.Weight > maxWeight)
            {
                Console.WriteLine("Your bag got too heavy so you decided to not put the item into your bag.");
            }
            else if (currentVolumn + newItem.Volumn > maxVolumn)
            {
                Console.WriteLine("There is no space in your bag so you decided to not put the item into your bag.");
            }
        }

        // helper method
        public Items findItem(String targetItem)
        {
            Items search;
            if(inventory.ContainsKey(targetItem))
            {
                search = inventory[targetItem];
            }
            else
            {
                search = null;
            }
            return search;
        }

        public void discardItem(String itemName)
        {
            Items target = findItem(itemName);
            if(target.Type == ItemType.KEYITEM)
            {
                //place holder for now
                Console.WriteLine("This is an key item you cannot discard it!");
            }
            else if(target == null)
            {
                //place holder for now
                Console.WriteLine("Item does not exist in inventory!");
            }
            else
            {
                currentWeight -= target.Weight;
                currentVolumn -= target.Volumn;
                inventory.Remove(target.ItemName);
            }
        }

        public void useItem(String itemName)
        {
            Items target = findItem(itemName);
            if (target.Type == ItemType.KEYITEM)
            {
                //place holder for now
                Console.WriteLine("This is an key item you cannot discard it!");
            }
            else if (target == null)
            {
                //place holder for now
                Console.WriteLine("Item does not exist in inventory!");
            }
            else
            {
                currentWeight -= target.Weight;
                currentVolumn -= target.Volumn;
                // need to finish setting up consumables
                inventory.Remove(target.ItemName);
            }
        }
    }
}
