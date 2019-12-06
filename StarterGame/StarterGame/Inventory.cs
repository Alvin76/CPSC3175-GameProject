using System;
using System.Collections.Generic;
using System.Text;
using StarterGame.Goods;

namespace StarterGame
{
    class Inventory
    {
        private static Inventory playerInventory = null;
        public List<IGoods.IGoods> inventory;
        private static float maxVolumn; // m^3
        private static float maxWeight; // kg
        private float currentVolumn;
        private float currentWeight;

        private Inventory()
        {
            inventory = new List<IGoods.IGoods>();
            maxVolumn = 200f;
            maxWeight = 20f;
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
        public void addItem(IGoods.IGoods newItem)
        {
            if(currentWeight + newItem.Weight <= maxWeight && currentVolumn + newItem.Volumn <= maxVolumn)
            {
                inventory.Add(newItem);
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
        public IGoods.IGoods findItem(String targetItem)
        {
            IGoods.IGoods search = null ;
            for(int index = 0; index < inventory.Count; index++)
            {
                if(inventory[index].ItemName == targetItem)
                {
                    search = inventory[index];
                }
            }
            return search;
        }

        public void discardItem(String itemName)
        {
            IGoods.IGoods target = findItem(itemName);
            if(target == null)
            {
                //place holder for now
                Console.WriteLine("Item does not exist in inventory!");
            }
            else
            {
                currentWeight -= target.Weight;
                currentVolumn -= target.Volumn;
                if (target.Count > 1)
                {
                    findItem(itemName).Count -= 1;
                }
                else
                {
                    inventory.Remove(target);
                }
            }
        }

        public void useItem(String itemName)
        {
            IGoods.IGoods target = findItem(itemName);
            if (target == null)
            {
                //place holder for now
                Console.WriteLine("Item does not exist in inventory!");
            }
            else
            {
                currentWeight -= target.Weight;
                currentVolumn -= target.Volumn;
                if(target.Count > 1)
                {
                    findItem(itemName).Count -= 1;
                }
                else
                {
                    inventory.Remove(target);
                }
            }
        }
    }
}
