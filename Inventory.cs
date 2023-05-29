﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Inventory
    {
        private int capacity = 10;
        private int totalItem;
        protected float gold;

        private Dictionary<string, Item> items;

        public float Gold { get => gold; }
        public Dictionary<string, Item> Items { get => items; }

        //constructor
        public Inventory()
        {
            totalItem = 0;
            gold = 0;
            items = new Dictionary<string, Item>(capacity);
        }
        //constructor


        //Store item
        public void StoreItem(Item item)
        {
            if (totalItem >= 10)
                return;

            if (Items.ContainsKey(item.Name))
            {
                AddGold(Items[item.Name].Price);
                Items[item.Name] = item;
            }
            else
            {
                Items.Add(item.Name, item);
                totalItem++;
            }
        }
        //Store item

        //Sell item
        public void SellItem(Item item)
        {
            if (totalItem <= 0)
                return;

            if (Items.ContainsKey(item.Name))
            {
                AddGold(item.Price);
                Items.Remove(item.Name);
                totalItem--;
            }
            else return;
        }
        //Sell item


        //Sell Rare and Epic items
        public void SellItem(Item item, bool condition)
        {
            if (!condition)
                return;
            else
                SellItem(item);
        }
        //Sell Rare and Epic items

        //Add gold
        public void AddGold(float value)
        { gold += value; } 
        //Add gold


        //Show all item
        public void ShowAllItem()
        {
            //GameUtilities.SortInventory(items);
            foreach (string key in items.Keys)
                items[key].ShowInfor();

        }//Show all item
    }
}
