using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Inventory
    {
        protected int capacity = 10;
        protected int totalItem = 0;
        protected float gold = 0;

        protected Item[] items;

        public Inventory() 
        {
            totalItem = 0;
            gold = 0;
            items = new Item[capacity];
        }

        public void StoreItem(Item item)
        {
            if (totalItem >= 10)
                return;

            items[totalItem] = item;
            totalItem++;
        }

        public void SellItem(Item item)
        {
            if (totalItem <= 0)
                return;
            
            for (int i = 0; i < items.Length; i++)
            {
                if (item.itemID == items[i].itemID)
                {
                    AddGold(item.Price);
                    GameUtilities.RemoveItem(items, i);
                }
            }
        }

        public void AddGold(float value)
        { gold += value; }

        public void ShowAllItem()
        {
            foreach (Item item in items)
            {
                if (item == null)
                    continue;

                item.ShowInfor();
            }

        }

    }
}
